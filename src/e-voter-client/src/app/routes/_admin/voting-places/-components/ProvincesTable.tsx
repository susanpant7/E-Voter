import {useState} from 'react';
import {EditButton} from "../../../../../componenets/UI/EditButton.tsx";
import {DeleteButton} from "../../../../../componenets/UI/DeleteButton.tsx";
import {useQuery, useQueryClient} from "@tanstack/react-query";
import {
    getProvincesQueryOptions, queryKeys
} from "../-api/voting-place-query-options.ts";
import {ExpandCollapseIcon} from "../../../../../componenets/UI/ExpandCollapseIcon.tsx";
import type {ProvinceInfo} from "../-api/voting-place.types.ts";
import DistrictsTable from "./DistrictsTable.tsx";
import {AddButton} from "../../../../../componenets/UI/AddButton.tsx";
import {AddEditModal} from "./AddEditModal.tsx";
import {TextInput} from "../../../../../componenets/UI/TextInput.tsx";
import {addProvince, deleteProvince, updateProvince} from "../-api/voting-place.api.ts";

const ProvincesTable = () => {
    const { data, isPending } = useQuery(getProvincesQueryOptions());
    const [expandedRowId, setExpandedRowId] = useState<string | number | null>(null);
    const [openAddEditModal, setOpenAddEditModal] = useState(false);
    const [addEditProvince, setAddEditProvince] = useState<Partial<ProvinceInfo>>({})
    const queryClient = useQueryClient();
    
    const toggleRow = (item: ProvinceInfo) => {
        setOpenAddEditModal(false);
        setExpandedRowId(prevId => prevId === item.provinceId ? null : item.provinceId);
    }
    
    const onEditButtonClick = (provinceInfo: ProvinceInfo) => {
        setOpenAddEditModal(true)
        setAddEditProvince(provinceInfo)
    };

    const onDeleteButtonClick = async (provinceInfo: ProvinceInfo) => {
        const confirmDelete = window.confirm(`Are you sure you want to delete province with ID: ${provinceInfo.provinceId}?`);
        if (confirmDelete) {
            await deleteProvince(provinceInfo.provinceId)
            await queryClient.invalidateQueries({ queryKey: queryKeys.provinces });
        } else {
            alert('Delete cancelled');
        }
    };

    const onAddButtonClick = () => {
        setOpenAddEditModal(true);
        setAddEditProvince({})
    }

    const onAddEditSave = async () => {
        const request = {
            provinceCode: addEditProvince.provinceCode!,
            provinceName: addEditProvince.provinceName!
        }
        if(addEditProvince.provinceId){
            const resp = await updateProvince({...request, provinceId:addEditProvince.provinceId});
            console.log(resp);
            
        } else {
            const resp = await addProvince(request);
            console.log(resp);
        }
        await queryClient.invalidateQueries({ queryKey: queryKeys.provinces });
        setOpenAddEditModal(false);
        setAddEditProvince({})
    }

    if (isPending) {
        return <div className="p-6">Loading provinces...</div>;
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
                                Province Name
                            </th>
                            <th className="py-3 px-6 text-left text-sm font-semibold text-gray-700 border-b border-gray-300">
                                Province Code
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
                                        <span>No provinces found. Add new province</span>

                                        {!openAddEditModal && (
                                            <AddButton onClick={() => onAddButtonClick()} />
                                        )}
                                    </div>
                                </td>
                            </tr>
                        )}
                        {data?.map((province,index) => {
                            // This derived variable is unique to every row render
                            const isRowExpanded = expandedRowId === province.provinceId;
                            const isLastRow = index === (data?.length ?? 0) - 1;
                            return (
                                <>
                                    <tr key={province.provinceId}>
                                        <td className="px-4 py-3">
                                            <button onClick={() => toggleRow(province)}>
                                                {/* Pass the derived boolean here */}
                                                <ExpandCollapseIcon isExpanded={isRowExpanded} />
                                            </button>
                                        </td>
                                        {/* Province Name Column */}
                                        <td className="py-4 px-6">
                                            <div className="text-gray-800 font-medium">
                                                {province.provinceName}
                                            </div>
                                        </td>

                                        {/* Code Column */}
                                        <td className="py-4 px-6">
                                            <div className="text-gray-700 font-mono">
                                                {province.provinceCode}
                                            </div>
                                        </td>

                                        {/* Actions Column */}
                                        <td className="py-4 px-6">
                                            <div className="flex space-x-2">
                                                <EditButton
                                                    onClick={() => onEditButtonClick(province)}
                                                />
                                                <DeleteButton
                                                    onClick={() => onDeleteButtonClick(province)}
                                                />
                                                {isLastRow && !openAddEditModal && (
                                                    <AddButton onClick={()=>onAddButtonClick()} />
                                                )}
                                            </div>
                                        </td>
                                    </tr>
                                    {
                                        isRowExpanded &&
                                        <tr className="bg-gray-50">
                                            <td colSpan={5} className="p-0 border-b border-gray-200">
                                                <div className="w-full pl-12 pr-4 py-4 bg-gray-50/60 border-l-4 border-indigo-500 rounded-r-md space-y-3">
                                                    <div className="text-sm font-medium text-gray-700">
                                                        Districts under
                                                        <span className="mx-1 rounded bg-indigo-50 px-2 py-0.5 font-semibold text-indigo-700">
                                                            {province.provinceName}
                                                        </span>
                                                        province
                                                    </div>

                                                    <DistrictsTable provinceInfo={province} />
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
                title={`${addEditProvince?.provinceId? 'Edit' : 'Add'} Province`}
                onClose={() => setOpenAddEditModal(false)}
                onSave={onAddEditSave}
            >
                <div className="space-y-4">
                    <div>
                        <TextInput 
                            required={true}
                            label={'Province Name'} 
                            value={addEditProvince?.provinceName || ""}
                            onChange={(e) =>
                                setAddEditProvince((prev) => ({
                                    ...prev,
                                    provinceName: e.target.value,
                                }))
                            }
                        />
                    </div>

                    <div>
                        <TextInput
                            required={true}
                            label={'Province Code'}
                            value={addEditProvince?.provinceCode || ""}
                            onChange={(e) =>
                                setAddEditProvince((prev) => ({
                                    ...prev,
                                    provinceCode: e.target.value,
                                }))
                            }
                        />
                    </div>
                </div>
            </AddEditModal>
            
        </div>
    );
};

export default ProvincesTable;