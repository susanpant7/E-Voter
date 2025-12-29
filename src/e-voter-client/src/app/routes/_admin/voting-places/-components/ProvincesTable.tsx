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
import {isEmpty} from "../../../../../utils/input-validators.ts";

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
        if(isEmpty(addEditProvince.provinceCode) || isEmpty(addEditProvince.provinceName)){
            return;
        }
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
            <div className="max-w-6xl mx-auto border rounded-lg bg-white">
                <div className="flex items-center justify-start gap-4 px-4 py-3 border-b bg-gray-50 rounded-t-md">
                    <h2 className="text-lg sm:text-xl font-bold text-gray-800 tracking-wide relative">
                        <span className="inline-block mr-2 animate-pulse">📍</span>
                        Provinces
                        <span className="ml-2 w-16 h-1 bg-indigo-500 rounded-full block absolute bottom-0 left-0"></span>
                    </h2>
                    <AddButton label="Add Province" onClick={onAddButtonClick} />
                </div>

                <table className="w-full">
                    <thead className="bg-gray-100 text-sm text-gray-700">
                    <tr>
                        <th className="w-12 px-4 py-2"></th>
                        <th className="px-4 py-2 text-left">Province Name</th>
                        <th className="px-4 py-2 text-left">Province Code</th>
                        <th className="px-4 py-2"></th>
                    </tr>
                    </thead>

                    <tbody>
                    {(!data || data.length === 0) && (
                        <tr>
                            <td colSpan={4} className="py-10 text-center text-gray-500">
                                No provinces found
                            </td>
                        </tr>
                    )}

                    {data?.map((province, index) => {
                        const isExpanded = expandedRowId === province.provinceId;
                        if (expandedRowId !== null && index > data.findIndex(p => p.provinceId === expandedRowId)) {
                            return null;
                        }
                        return (
                            <>
                                <tr
                                    key={province.provinceId}
                                    className="border-b hover:bg-gray-50 transition"
                                >
                                    <td className="px-4 py-2">
                                        <button onClick={() => toggleRow(province)}>
                                            <ExpandCollapseIcon isExpanded={isExpanded} />
                                        </button>
                                    </td>

                                    <td className="px-4 py-2 font-medium">
                                        {province.provinceName}
                                    </td>

                                    <td className="px-4 py-2 font-mono">
                                        {province.provinceCode}
                                    </td>

                                    <td className="px-4 py-2">
                                        <div className="flex gap-2">
                                            <EditButton onClick={() => onEditButtonClick(province)} />
                                            <DeleteButton onClick={() => onDeleteButtonClick(province)} />
                                        </div>
                                    </td>
                                </tr>

                                {isExpanded && (
                                    <tr className="animate-fadeIn">
                                        <td colSpan={4} className="p-0">
                                            <div className="pl-10 py-4 border-l-4 border-indigo-500 bg-indigo-50/50">
                                                <DistrictsTable provinceInfo={province} />
                                            </div>
                                        </td>
                                    </tr>
                                )}
                            </>
                        );
                    })}
                    </tbody>
                </table>
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