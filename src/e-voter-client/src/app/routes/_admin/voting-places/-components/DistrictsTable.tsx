import {useState} from 'react';
import {EditButton} from "../../../../../componenets/UI/EditButton.tsx";
import {DeleteButton} from "../../../../../componenets/UI/DeleteButton.tsx";
import {useQuery, useQueryClient} from "@tanstack/react-query";
import {getDistrictsByProvinceIdQueryOptions, queryKeys} from "../-api/voting-place-query-options.ts";
import {ExpandCollapseIcon} from "../../../../../componenets/UI/ExpandCollapseIcon.tsx";
import type {DistrictInfo, ProvinceInfo} from "../-api/voting-place.types.ts";
import MunicipalitiesTable from "./MunicipalitiesTable.tsx";
import {AddButton} from "../../../../../componenets/UI/AddButton.tsx";
import {TextInput} from "../../../../../componenets/UI/TextInput.tsx";
import {AddEditModal} from "./AddEditModal.tsx";
import {addDistrict, deleteProvince, updateDistrict} from "../-api/voting-place.api.ts";

interface DistrictsTableProps {
    provinceInfo: ProvinceInfo;
}

const DistrictsTable = (props:DistrictsTableProps) => {
    const { data, isPending } = useQuery(getDistrictsByProvinceIdQueryOptions(props.provinceInfo.provinceId));
    const [expandedRowId, setExpandedRowId] = useState<string | number | null>(null);
    const [openAddEditModal, setOpenAddEditModal] = useState(false);
    const [addEditDistrict, setAddEditDistrict] = useState<Partial<DistrictInfo>>({})
    const queryClient = useQueryClient();
    
    const toggleRow = (item: DistrictInfo) => {
        setOpenAddEditModal(false);
        setExpandedRowId(prevId => prevId === item.districtId ? null : item.districtId);
    }

    const onEditButtonClick = (districtInfo: DistrictInfo) => {
        setOpenAddEditModal(true)
        setAddEditDistrict(districtInfo)
    };

    const onDeleteButtonClick = async (districtInfo: DistrictInfo) => {
        const confirmDelete = window.confirm(`Are you sure you want to delete district : ${districtInfo.districtName}?`);
        if (confirmDelete) {
            await deleteProvince(districtInfo.districtId)
            await queryClient.invalidateQueries({ queryKey: queryKeys.districts(districtInfo.provinceId) });
        } else {
            alert('Delete cancelled');
        }
    };

    const onAddButtonClick = () => {
        setOpenAddEditModal(true);
        setAddEditDistrict({})
    }

    const onAddEditSave = async () => {
        const request = {
            districtCode: addEditDistrict.districtCode!,
            districtName: addEditDistrict.districtName!
        }
        if(addEditDistrict.districtId){
            const resp = await updateDistrict({...request, districtId:addEditDistrict.districtId});
            console.log(resp);

        } else {
            const resp = await addDistrict({...request, provinceId:props.provinceInfo.provinceId});
            console.log(resp);
        }
        await queryClient.invalidateQueries({ queryKey: queryKeys.districts(props.provinceInfo.provinceId) });
        setOpenAddEditModal(false);
        setAddEditDistrict({})
    }

    if (isPending) {
        return <div className="p-6">Loading districts...</div>;
    }

    return (
        <div>
            <div className="max-w-4xl mx-auto">
                {/* Table */}
                <div className="bg-white rounded-lg shadow border border-gray-200 overflow-hidden">
                    <table className="w-full">
                        {/* Table Header */}
                        <thead>
                        <tr className="bg-gray-100">
                            <th className="w-12 px-4 py-3"></th>
                            <th className="py-3 px-6 text-left text-sm font-semibold text-gray-700 border-b border-gray-300">
                                District Name
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
                                        <span>No districts found. Add new districts :</span>

                                        {!openAddEditModal && (
                                            <AddButton onClick={() => onAddButtonClick()} />
                                        )}
                                    </div>
                                </td>
                            </tr>
                        )}
                        {data?.map((district,index) => {
                            // This derived variable is unique to every row render
                            const isRowExpanded = expandedRowId === district.districtId;
                            const isLastRow = index === (data?.length ?? 0) - 1;
                            return (
                                <>
                                    <tr key={district.districtId}>
                                        <td className="px-4 py-3">
                                            <button onClick={() => toggleRow(district)}>
                                                <ExpandCollapseIcon isExpanded={isRowExpanded} />
                                            </button>
                                        </td>
                                        {/* Province Name Column */}
                                        <td className="py-4 px-6">
                                            <div className="text-gray-800 font-medium">
                                                {district.districtName}
                                            </div>
                                        </td>

                                        {/* Code Column */}
                                        <td className="py-4 px-6">
                                            <div className="text-gray-700 font-mono">
                                                {district.districtCode}
                                            </div>
                                        </td>

                                        {/* Actions Column */}
                                        <td className="py-4 px-6">
                                            <div className="flex space-x-2">
                                                <EditButton
                                                    onClick={() => onEditButtonClick(district)}
                                                />
                                                <DeleteButton
                                                    onClick={() => onDeleteButtonClick(district)}
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
                                                    <MunicipalitiesTable districtInfo={district} />
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
                title={`${addEditDistrict?.provinceId? 'Edit' : 'Add'} District`}
                onClose={() => setOpenAddEditModal(false)}
                onSave={onAddEditSave}
            >
                <div className="space-y-4">
                    <div>
                        <TextInput
                            label={'District Name'}
                            value={addEditDistrict?.districtName || ""}
                            onChange={(e) =>
                                setAddEditDistrict((prev) => ({
                                    ...prev,
                                    districtName: e.target.value,
                                }))
                            }
                        />
                    </div>

                    <div>
                        <TextInput
                            label={'District Code'}
                            value={addEditDistrict?.districtCode || ""}
                            onChange={(e) =>
                                setAddEditDistrict((prev) => ({
                                    ...prev,
                                    districtCode: e.target.value,
                                }))
                            }
                        />
                    </div>
                </div>
            </AddEditModal>
        </div>
    );
};

export default DistrictsTable;