import {useState} from 'react';
import {EditButton} from "../../../../../componenets/UI/EditButton.tsx";
import {DeleteButton} from "../../../../../componenets/UI/DeleteButton.tsx";
import {useQuery, useQueryClient} from "@tanstack/react-query";
import {
    getMunicipalitiesByDistrictIdQueryOptions, queryKeys
} from "../-api/voting-place-query-options.ts";
import {ExpandCollapseIcon} from "../../../../../componenets/UI/ExpandCollapseIcon.tsx";
import {
    type DistrictInfo,
    type MunicipalityInfo,
    type MunicipalityType,
    MunicipalityTypeOptions
} from "../-api/voting-place.types.ts";
import WardsTable from "./WardsTable.tsx";
import {AddButton} from "../../../../../componenets/UI/AddButton.tsx";
import {TextInput} from "../../../../../componenets/UI/TextInput.tsx";
import {AddEditModal} from "./AddEditModal.tsx";
import {
    addMunicipality,
    deleteMunicipality,
    updateMunicipality
} from "../-api/voting-place.api.ts";
import {SelectInput} from "../../../../../componenets/UI/SelectInput.tsx";

interface MunicipalitiesTableProps {
    districtInfo: DistrictInfo;
}

const MunicipalitiesTable = (props:MunicipalitiesTableProps) => {
    const { data, isPending } = useQuery(getMunicipalitiesByDistrictIdQueryOptions(props.districtInfo.districtId));
    const [expandedRowId, setExpandedRowId] = useState<string | number | null>(null);
    const [openAddEditModal, setOpenAddEditModal] = useState(false);
    const [addEditMunicipality, setAddEditMunicipality] = useState<Partial<MunicipalityInfo>>({})
    const queryClient = useQueryClient();
    
    const toggleRow = (item: MunicipalityInfo) => {
        setExpandedRowId(prevId => prevId === item.municipalityId ? null : item.municipalityId);
    }

    const onEditButtonClick = (item: MunicipalityInfo) => {
        setOpenAddEditModal(true)
        setAddEditMunicipality(item)
    };

    const onDeleteButtonClick = async (item: MunicipalityInfo) => {
        const confirmDelete = window.confirm(`Are you sure you want to delete municipality : ${item.municipalityName}?`);
        if (confirmDelete) {
            await deleteMunicipality(item.municipalityId)
            await queryClient.invalidateQueries({ queryKey: queryKeys.municipalities(item.districtId) });
        } else {
            alert('Delete cancelled');
        }
    };

    const onAddButtonClick = () => {
        setOpenAddEditModal(true);
        setAddEditMunicipality({})
    }

    const onAddEditSave = async () => {
        const request = {
            municipalityCode: addEditMunicipality.municipalityCode!,
            municipalityName: addEditMunicipality.municipalityName!,
            municipalityType: addEditMunicipality.municipalityType!,
        }
        if(addEditMunicipality.municipalityId){
            const resp = await updateMunicipality({...request, districtId:props.districtInfo.districtId, municipalityId:addEditMunicipality.municipalityId});
            console.log(resp);

        } else {
            const resp = await addMunicipality({...request, districtId:props.districtInfo.districtId});
            console.log(resp);
        }
        await queryClient.invalidateQueries({ queryKey: queryKeys.municipalities(props.districtInfo.districtId) });
        setOpenAddEditModal(false);
        setAddEditMunicipality({})
    }

    if (isPending) {
        return <div className="p-6">Loading municipalities...</div>;
    }

    return (
        <div >
            <div className="max-w-4xl mx-auto">
                {/* Table */}
                <div className="bg-white rounded-lg shadow border border-gray-200 overflow-hidden">
                    <table className="w-full">
                        {/* Table Header */}
                        <thead>
                        <tr className="bg-gray-100">
                            <th className="w-12 px-4 py-3"></th>
                            <th className="py-3 px-6 text-left text-sm font-semibold text-gray-700 border-b border-gray-300">
                                Name
                            </th>
                            <th className="py-3 px-6 text-left text-sm font-semibold text-gray-700 border-b border-gray-300">
                                Code
                            </th>
                            <th className="py-3 px-6 text-left text-sm font-semibold text-gray-700 border-b border-gray-300">
                                
                            </th>
                        </tr>
                        </thead>

                        {/* Table Body */}
                        <tbody>
                        {(!data || data.length === 0) && (
                            <tr>
                                <td colSpan={5} className="py-10 text-center">
                                    <div className="flex flex-col items-center gap-3 text-gray-500">
                                        <span>No municipalities found. Add new municipality: </span>

                                        {!openAddEditModal && (
                                            <AddButton onClick={() => onAddButtonClick()} />
                                        )}
                                    </div>
                                </td>
                            </tr>
                        )}
                        {data?.map((municipality,index) => {
                            // This derived variable is unique to every row render
                            const isRowExpanded = expandedRowId === municipality.municipalityId;
                            const isLastRow = index === (data?.length ?? 0) - 1;
                            return (
                                <>
                                    <tr key={municipality.municipalityId}>
                                        <td className="px-4 py-3">
                                            <button onClick={() => toggleRow(municipality)}>
                                                <ExpandCollapseIcon isExpanded={isRowExpanded} />
                                            </button>
                                        </td>
                                        {/* Province Name Column */}
                                        <td className="py-4 px-6">
                                            <div className="text-gray-800 font-medium">
                                                {municipality.municipalityName}
                                            </div>
                                        </td>

                                        {/* Code Column */}
                                        <td className="py-4 px-6">
                                            <div className="text-gray-700 font-mono">
                                                {municipality.municipalityCode}
                                            </div>
                                        </td>

                                        {/* Actions Column */}
                                        <td className="py-4 px-6">
                                            <div className="flex space-x-2">
                                                <EditButton
                                                    onClick={() => onEditButtonClick(municipality)}
                                                />
                                                <DeleteButton
                                                    onClick={() => onDeleteButtonClick(municipality)}
                                                />
                                                {isLastRow && !openAddEditModal && (
                                                    <AddButton onClick={()=>onAddButtonClick()} />
                                                )}
                                            </div>
                                        </td>
                                    </tr>
                                    { isRowExpanded &&
                                        <tr className="bg-gray-50">
                                            <td colSpan={5} className="p-0 border-b border-gray-200">
                                                <div className="w-full pl-12 pr-4 py-4 bg-gray-50/50 border-l-4 border-indigo-500">
                                                    <WardsTable municipalityInfo={municipality} />
                                                </div>
                                            </td>
                                        </tr>
                                    }
                                </>

                            );
                        })}

                        </tbody>
                    </table>
                </div>
            </div>
            <AddEditModal
                isOpen={openAddEditModal}
                title={`${addEditMunicipality?.municipalityId? 'Edit' : 'Add'} Municipality`}
                onClose={() => setOpenAddEditModal(false)}
                onSave={onAddEditSave}
            >
                <div className="space-y-4">
                    <div>
                        <TextInput
                            label={'Municipality Name'}
                            value={addEditMunicipality?.municipalityName || ""}
                            onChange={(e) =>
                                setAddEditMunicipality((prev) => ({
                                    ...prev,
                                    municipalityName: e.target.value,
                                }))
                            }
                        />
                    </div>

                    <div>
                        <TextInput
                            label={'Municipality Code'}
                            value={addEditMunicipality?.municipalityCode || ""}
                            onChange={(e) =>
                                setAddEditMunicipality((prev) => ({
                                    ...prev,
                                    municipalityCode: e.target.value,
                                }))
                            }
                        />
                    </div>
                    <SelectInput
                        label={ "Municipality Type" + addEditMunicipality.municipalityType?.toString() }
                        options={MunicipalityTypeOptions}
                        value={addEditMunicipality.municipalityType?.toString() || ""}
                        onChange={(e) => {
                            setAddEditMunicipality((prev) => ({
                                ...prev,
                                municipalityType: Number(e.target.value) as MunicipalityType
                            }));
                        }}
                        required={true}
                        errorMessage="Please select a municipality type"
                    />
                </div>
            </AddEditModal>
        </div>
    );
};

export default MunicipalitiesTable;