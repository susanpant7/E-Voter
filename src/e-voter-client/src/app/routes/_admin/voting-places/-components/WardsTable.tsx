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
import {isEmpty} from "../../../../../utils/input-validators.ts";

interface WardsTableProps {
    municipalityInfo: MunicipalityInfo;
    provinceName: string;
    districtName: string;
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
        if(isEmpty(addEditWard.wardName) || isEmpty(addEditWard.wardNumber?.toString()) || addEditWard.wardNumber == 0){
            return;
        }
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
            <div className="border rounded-md bg-amber-50">
                <div className="flex items-center justify-start gap-3 px-4 py-2 border-b border-amber-200 bg-amber-50 rounded-t-md">
                    {/* Title */}
                    <h3 className="text-sm sm:text-base font-bold text-amber-900 tracking-wide flex-1 truncate flex items-center gap-1 relative">
                        <span className="inline-block animate-pulse shrink-0">🟠</span>
                        <span className="truncate">
                          Wards in Province: <span className="font-semibold">{props.provinceName}</span> | 
                          District: <span className="font-semibold">{props.districtName}</span> | 
                          Municipality: <span className="font-semibold">{props.municipalityInfo.municipalityName}</span>
                        </span>
                        <span className="absolute bottom-0 left-0 w-16 h-0.5 bg-amber-500 rounded-full"></span>
                    </h3>

                    {/* Add Button */}
                    <AddButton label="Add Ward" onClick={onAddButtonClick} />
                </div>



                <div className={data?.length ? "max-h-[220px] overflow-y-auto" : ""}>
                    <table className="w-full">
                        <thead className="bg-amber-100 text-sm">
                        <tr>
                            <th className="w-12 px-3 py-2"></th>
                            <th className="px-3 py-2 text-left">Ward Name</th>
                            <th className="px-3 py-2 text-left">Ward Number</th>
                            <th className="px-3 py-2"></th>
                        </tr>
                        </thead>

                        <tbody>
                        {(!data || data.length === 0) && (
                            <tr>
                                <td colSpan={4} className="py-8 text-center text-gray-500">
                                    No wards
                                </td>
                            </tr>
                        )}

                        {data?.map((ward,index) => {
                            const isExpanded = expandedRowId === ward.wardId;
                            if (expandedRowId !== null && index > data.findIndex(p => p.wardId === expandedRowId)) {
                                return null;
                            }
                            return (
                                <>
                                    <tr
                                        key={ward.wardId}
                                        className="border-b hover:bg-amber-100 transition"
                                    >
                                        <td className="px-3 py-2">
                                            <button onClick={() => toggleRow(ward)}>
                                                <ExpandCollapseIcon isExpanded={isExpanded} />
                                            </button>
                                        </td>

                                        <td className="px-3 py-2">{ward.wardName}</td>
                                        <td className="px-3 py-2 font-mono">{ward.wardNumber}</td>

                                        <td className="px-3 py-2">
                                            <div className="flex gap-2">
                                                <EditButton onClick={() => onEditButtonClick(ward)} />
                                                <DeleteButton onClick={() => onDeleteButtonClick(ward)} />
                                            </div>
                                        </td>
                                    </tr>

                                    {isExpanded && (
                                        <tr className="animate-slideDown">
                                            <td colSpan={4} className="pl-10 py-3 bg-amber-100/50">
                                                <VotingAreasTable wardInfo={ward} districtName={props.districtName} provinceName={props.provinceName} municipalityName={props.municipalityInfo.municipalityName} />
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
                title={`${addEditWard?.wardId? 'Edit' : 'Add'} Ward`}
                onClose={() => setOpenAddEditModal(false)}
                onSave={onAddEditSave}
            >
                <div className="space-y-4">
                    <div>
                        <TextInput
                            required={true}
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
                            required={true}
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