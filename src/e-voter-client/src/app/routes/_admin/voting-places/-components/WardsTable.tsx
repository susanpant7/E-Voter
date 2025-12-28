import {useState} from 'react';
import {EditButton} from "../../../../../componenets/UI/EditButton.tsx";
import {DeleteButton} from "../../../../../componenets/UI/DeleteButton.tsx";
import {useQuery, useQueryClient} from "@tanstack/react-query";
import {
    getWardsByMunicipalityIdQueryOptions, queryKeys
} from "../-api/voting-place-query-options.ts";
import {ExpandCollapseIcon} from "../../../../../componenets/UI/ExpandCollapseIcon.tsx";
import type {MunicipalityInfo, WardInfo} from "../-api/voting-place.types.ts";
import VotingAreasTable from "./VotingAreasTable.tsx";
import {AddButton} from "../../../../../componenets/UI/AddButton.tsx";
import {TextInput} from "../../../../../componenets/UI/TextInput.tsx";
import {AddEditModal} from "./AddEditModal.tsx";
import {NumberInput} from "../../../../../componenets/UI/NumberInput.tsx";
import {
    addWard,
    deleteWard,
    updateWard
} from "../-api/voting-place.api.ts";

interface WardsTableProps {
    municipalityInfo: MunicipalityInfo;
}

const WardsTable = (props:WardsTableProps) => {
    const { data, isPending } = useQuery(getWardsByMunicipalityIdQueryOptions(props.municipalityInfo.municipalityId));
    const [expandedRowId, setExpandedRowId] = useState<string | number | null>(null);
    const [openAddEditModal, setOpenAddEditModal] = useState(false);
    const [addEditWard, setAddEditWard] = useState<Partial<WardInfo>>({})
    const queryClient = useQueryClient();
    
    const toggleRow = (item: WardInfo) => {
        setExpandedRowId(prevId => prevId === item.wardId ? null : item.wardId);
    }

    const onEditButtonClick = (item: WardInfo) => {
        setOpenAddEditModal(true)
        setAddEditWard(item)
    };

    const onDeleteButtonClick = async (item: WardInfo) => {
        const confirmDelete = window.confirm(`Are you sure you want to delete ward : ${item.wardName}?`);
        if (confirmDelete) {
            await deleteWard(item.wardId)
            await queryClient.invalidateQueries({ queryKey: queryKeys.wards(item.municipalityId) });
        } else {
            alert('Delete cancelled');
        }
    };

    const onAddButtonClick = () => {
        setOpenAddEditModal(true);
        setAddEditWard({})
    }

    const onAddEditSave = async () => {
        const request = {
            wardName: addEditWard.wardName!,
            wardNumber: addEditWard.wardNumber!,
        }
        if(addEditWard.wardId){
            const resp = await updateWard({...request, municipalityId:props.municipalityInfo.municipalityId, wardId:addEditWard.wardId});
            console.log(resp);

        } else {
            const resp = await addWard({...request, municipalityId:props.municipalityInfo.municipalityId});
            console.log(resp);
        }
        await queryClient.invalidateQueries({ queryKey: queryKeys.wards(props.municipalityInfo.municipalityId) });
        setOpenAddEditModal(false);
        setAddEditWard({})
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
                        <thead>
                        <tr className="bg-gray-100">
                            <th className="w-12 px-4 py-3"></th>
                            <th className="py-3 px-6 text-left text-sm font-semibold text-gray-700 border-b border-gray-300">
                                Ward Name
                            </th>
                            <th className="py-3 px-6 text-left text-sm font-semibold text-gray-700 border-b border-gray-300">
                                Ward Number
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
                                        <span>No wards found. Add new wards: </span>

                                        {!openAddEditModal && (
                                            <AddButton onClick={() => onAddButtonClick()} />
                                        )}
                                    </div>
                                </td>
                            </tr>
                        )}
                        {data?.map((ward,index) => {
                            // This derived variable is unique to every row render
                            const isRowExpanded = expandedRowId === ward.wardId;
                            const isLastRow = index === (data?.length ?? 0) - 1;
                            return (
                                <>
                                    <tr key={ward.wardId}>
                                        <td className="px-4 py-3">
                                            <button onClick={() => toggleRow(ward)}>
                                                <ExpandCollapseIcon isExpanded={isRowExpanded} />
                                            </button>
                                        </td>
                                        {/* Province Name Column */}
                                        <td className="py-4 px-6">
                                            <div className="text-gray-800 font-medium">
                                                {ward.wardName}
                                            </div>
                                        </td>

                                        {/* Code Column */}
                                        <td className="py-4 px-6">
                                            <div className="text-gray-700 font-mono">
                                                {ward.wardNumber}
                                            </div>
                                        </td>

                                        {/* Actions Column */}
                                        <td className="py-4 px-6">
                                            <div className="flex space-x-2">
                                                <EditButton
                                                    onClick={() => onEditButtonClick(ward)}
                                                />
                                                <DeleteButton
                                                    onClick={() => onDeleteButtonClick(ward)}
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
                                                    <VotingAreasTable wardInfo={ward} />
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
                title={`${addEditWard?.wardId? 'Edit' : 'Add'} Ward`}
                onClose={() => setOpenAddEditModal(false)}
                onSave={onAddEditSave}
            >
                <div className="space-y-4">
                    <div>
                        <TextInput
                            label={'Ward Name'}
                            value={addEditWard?.wardName || ""}
                            onChange={(e) =>
                                setAddEditWard((prev) => ({
                                    ...prev,
                                    wardName: e.target.value,
                                }))
                            }
                        />
                    </div>

                    <div>
                        <NumberInput
                            label="Ward Number"
                            value={addEditWard?.wardNumber?.toString() ?? ""}
                            onChange={(value) =>
                                setAddEditWard((prev) => ({
                                    ...prev,
                                    wardNumber: Number(value),
                                }))
                            }
                        />
                    </div>
                </div>
            </AddEditModal>
        </div>
    );
};

export default WardsTable;