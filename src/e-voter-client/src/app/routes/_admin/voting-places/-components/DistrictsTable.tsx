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
import {isEmpty} from "../../../../../utils/input-validators.ts";

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
        if(isEmpty(addEditDistrict.districtCode) || isEmpty(addEditDistrict.districtName)){
            return
        }
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
            <div className="border rounded-md bg-blue-50">
                {/* HEADER */}
                <div className="flex items-center justify-start gap-3 px-4 py-2 border-b border-blue-200 bg-blue-50 rounded-t-md">
                    {/* Title */}
                    <h3 className="text-sm sm:text-base font-bold text-blue-900 tracking-wide relative flex items-center gap-1">
                        <span className="inline-block animate-pulse">📍</span>
                        Districts in Province: <span className="ml-1 font-semibold">{props.provinceInfo.provinceName}</span>
                        <span className="absolute bottom-0 left-0 w-12 h-0.5 bg-blue-500 rounded-full"></span>
                    </h3>

                    {/* Add Button */}
                    {!openAddEditModal && <AddButton label="Add District" onClick={onAddButtonClick} />}
                </div>


                <div className={data?.length ? "max-h-[500px] overflow-y-auto" : ""}>
                    <table className="w-full">
                        <thead className="bg-blue-100 text-sm">
                        <tr>
                            <th className="w-12 px-3 py-2"></th>
                            <th className="px-3 py-2 text-left">District Name</th>
                            <th className="px-3 py-2 text-left">District Code</th>
                            <th className="px-3 py-2"></th>
                        </tr>
                        </thead>

                        <tbody>
                        {(!data || data.length === 0) && (
                            <tr>
                                <td colSpan={4} className="py-8 text-center text-gray-500">
                                    No districts
                                </td>
                            </tr>
                        )}

                        {data?.map((district,index) => {
                            const isExpanded = expandedRowId === district.districtId;
                            if (expandedRowId !== null && index > data.findIndex(p => p.districtId === expandedRowId)) {
                                return null;
                            }
                            return (
                                <>
                                    <tr
                                        key={district.districtId}
                                        className="border-b hover:bg-blue-100 transition"
                                    >
                                        <td className="px-3 py-2">
                                            <button onClick={() => toggleRow(district)}>
                                                <ExpandCollapseIcon isExpanded={isExpanded} />
                                            </button>
                                        </td>

                                        <td className="px-3 py-2 font-medium">
                                            {district.districtName}
                                        </td>

                                        <td className="px-3 py-2 font-mono">
                                            {district.districtCode}
                                        </td>

                                        <td className="px-3 py-2">
                                            <div className="flex gap-2">
                                                <EditButton onClick={() => onEditButtonClick(district)} />
                                                <DeleteButton onClick={() => onDeleteButtonClick(district)} />
                                            </div>
                                        </td>
                                    </tr>

                                    {isExpanded && (
                                        <tr className="animate-slideDown">
                                            <td colSpan={4} className="pl-10 py-3 bg-blue-100/50">
                                                <MunicipalitiesTable districtInfo={district} provinceName={props.provinceInfo.provinceName} />
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
                title={`${addEditDistrict?.provinceId? 'Edit' : 'Add'} District`}
                onClose={() => setOpenAddEditModal(false)}
                onSave={onAddEditSave}
            >
                <div className="space-y-4">
                    <div>
                        <TextInput
                            required={true}
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
                            required={true}
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