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
import {isEmpty} from "../../../../../utils/input-validators.ts";

interface MunicipalitiesTableProps {
    districtInfo: DistrictInfo;
    provinceName: string;
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
        if(isEmpty(addEditMunicipality.municipalityCode) || isEmpty(addEditMunicipality.municipalityName) || !addEditMunicipality.municipalityType){
            return;
        }
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
            <div className="border rounded-md bg-emerald-50">
                <div className="flex items-center justify-start gap-3 px-4 py-2 border-b border-emerald-200 bg-emerald-50 rounded-t-md">
                    {/* Title */}
                    <h3 className="text-sm sm:text-base font-bold text-emerald-900 tracking-wide relative flex items-center gap-1">
                        <span className="inline-block animate-pulse">🏘️</span>
                        Municipalities in Province: <span className="font-semibold">{props.provinceName}</span> | District: <span className="font-semibold">{props.districtInfo.districtName}</span>
                        <span className="absolute bottom-0 left-0 w-14 h-0.5 bg-emerald-500 rounded-full"></span>
                    </h3>

                    {/* Add Button */}
                    {!openAddEditModal && <AddButton label="Add Municipality" onClick={onAddButtonClick} />}
                </div>


                <div className={data?.length ? "max-h-[260px] overflow-y-auto" : ""}>
                    <table className="w-full">
                        <thead className="bg-emerald-100 text-sm">
                        <tr>
                            <th className="w-12 px-3 py-2"></th>
                            <th className="px-3 py-2 text-left">Municipality Name</th>
                            <th className="px-3 py-2 text-left">Type</th>
                            <th className="px-3 py-2 text-left">Code</th>
                            <th className="px-3 py-2"></th>
                        </tr>
                        </thead>

                        <tbody>
                        {(!data || data.length === 0) && (
                            <tr>
                                <td colSpan={5} className="py-8 text-center text-gray-500">
                                    No municipalities
                                </td>
                            </tr>
                        )}

                        {data?.map((m,index) => {
                            const isExpanded = expandedRowId === m.municipalityId;
                            if (expandedRowId !== null && index > data.findIndex(p => p.municipalityId === expandedRowId)) {
                                return null;
                            }
                            return (
                                <>
                                    <tr
                                        key={m.municipalityId}
                                        className="border-b hover:bg-emerald-100 transition"
                                    >
                                        <td className="px-3 py-2">
                                            <button onClick={() => toggleRow(m)}>
                                                <ExpandCollapseIcon isExpanded={isExpanded} />
                                            </button>
                                        </td>

                                        <td className="px-3 py-2">{m.municipalityName}</td>
                                        <td className="px-3 py-2">{m.municipalityType}</td>
                                        <td className="px-3 py-2 font-mono">{m.municipalityCode}</td>

                                        <td className="px-3 py-2">
                                            <div className="flex gap-2">
                                                <EditButton onClick={() => onEditButtonClick(m)} />
                                                <DeleteButton onClick={() => onDeleteButtonClick(m)} />
                                            </div>
                                        </td>
                                    </tr>

                                    {isExpanded && (
                                        <tr className="animate-fadeIn">
                                            <td colSpan={5} className="pl-10 py-3 bg-emerald-100/50">
                                                <WardsTable municipalityInfo={m} provinceName={props.provinceName} districtName={props.districtInfo.districtName} />
                                            </td>
                                        </tr>
                                    )}
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
                            required={true}
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
                            required={true}
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