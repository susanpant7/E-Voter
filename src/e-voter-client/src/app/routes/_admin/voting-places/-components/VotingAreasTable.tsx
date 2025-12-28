import {EditButton} from "../../../../../componenets/UI/EditButton.tsx";
import {DeleteButton} from "../../../../../componenets/UI/DeleteButton.tsx";
import {useQuery, useQueryClient} from "@tanstack/react-query";
import {
    getVotingPlacesByWardIdQueryOptions, queryKeys
} from "../-api/voting-place-query-options.ts";
import type {VotingPlaceInfo, WardInfo} from "../-api/voting-place.types.ts";
import {useState} from "react";
import {AddButton} from "../../../../../componenets/UI/AddButton.tsx";
import {TextInput} from "../../../../../componenets/UI/TextInput.tsx";
import {AddEditModal} from "./AddEditModal.tsx";
import {
    addVotingPlace,
    deleteVotingPlace,
    updateVotingPlace,
} from "../-api/voting-place.api.ts";

interface VotingAreasTableProps {
    wardInfo: WardInfo;
}

const VotingAreasTable = (props:VotingAreasTableProps) => {
    const { data, isPending } = useQuery(getVotingPlacesByWardIdQueryOptions(props.wardInfo.wardId));
    const [openAddEditModal, setOpenAddEditModal] = useState(false);
    const [addEditVotingPlace, setAddEditVotingPlace] = useState<Partial<VotingPlaceInfo>>({})
    const queryClient = useQueryClient();

    const onEditButtonClick = (item: VotingPlaceInfo) => {
        setOpenAddEditModal(true)
        setAddEditVotingPlace(item)
    };

    const onDeleteButtonClick = async (item: VotingPlaceInfo) => {
        const confirmDelete = window.confirm(`Are you sure you want to delete voting place : ${item.votingPlaceName}?`);
        if (confirmDelete) {
            await deleteVotingPlace(item.votingPlaceId)
            await queryClient.invalidateQueries({ queryKey: queryKeys.wards(item.wardId) });
        } else {
            alert('Delete cancelled');
        }
    };

    const onAddButtonClick = () => {
        setOpenAddEditModal(true);
        setAddEditVotingPlace({})
    }

    const onAddEditSave = async () => {
        const request = {
            votingPlaceName: addEditVotingPlace.votingPlaceName!,
            votingPlaceAddress: addEditVotingPlace.votingPlaceAddress!,
        }
        if(addEditVotingPlace.votingPlaceId){
            const resp = await updateVotingPlace({...request, wardId:props.wardInfo.wardId, votingPlaceId:addEditVotingPlace.votingPlaceId});
            console.log(resp);

        } else {
            const resp = await addVotingPlace({...request, wardId:props.wardInfo.wardId});
            console.log(resp);
        }
        await queryClient.invalidateQueries({ queryKey: queryKeys.votingPlaces(props.wardInfo.wardId) });
        setOpenAddEditModal(false);
        setAddEditVotingPlace({})
    }

    if (isPending) {
        return <div className="p-6">Loading voting areas...</div>;
    }

    return (
        <div >
            <div className="max-w-4xl mx-auto">
                {/* Table */}
                <div className="bg-white rounded-lg shadow border border-gray-200 overflow-hidden">
                    <table className="w-full">
                        <thead>
                        <tr className="bg-gray-100">
                            <th className="py-3 px-6 text-left text-sm font-semibold text-gray-700 border-b border-gray-300">
                                Name
                            </th>
                            <th className="py-3 px-6 text-left text-sm font-semibold text-gray-700 border-b border-gray-300">
                                Address
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
                                        <span>No voting places found. Add new voting place: </span>

                                        {!openAddEditModal && (
                                            <AddButton onClick={() => onAddButtonClick()} />
                                        )}
                                    </div>
                                </td>
                            </tr>
                        )}
                        {data?.map((votingPlace,index) => {
                            const isLastRow = index === (data?.length ?? 0) - 1;
                            return (
                                <>
                                    <tr key={votingPlace.votingPlaceId}>
                                        <td className="py-4 px-6">
                                            <div className="text-gray-800 font-medium">
                                                {votingPlace.votingPlaceName}
                                            </div>
                                        </td>

                                        {/* Code Column */}
                                        <td className="py-4 px-6">
                                            <div className="text-gray-700 font-mono">
                                                {votingPlace.votingPlaceAddress}
                                            </div>
                                        </td>

                                        {/* Actions Column */}
                                        <td className="py-4 px-6">
                                            <div className="flex space-x-2">
                                                <EditButton
                                                    onClick={() => onEditButtonClick(votingPlace)}
                                                />
                                                <DeleteButton
                                                    onClick={() => onDeleteButtonClick(votingPlace)}
                                                />
                                                {isLastRow && !openAddEditModal && (
                                                    <AddButton onClick={()=>onAddButtonClick()} />
                                                )}
                                            </div>
                                        </td>
                                    </tr>
                                </>

                            );
                        })}

                        </tbody>
                    </table>
                </div>
            </div>
            <AddEditModal
                isOpen={openAddEditModal}
                title={`${addEditVotingPlace?.votingPlaceId? 'Edit' : 'Add'} Voting Place`}
                onClose={() => setOpenAddEditModal(false)}
                onSave={onAddEditSave}
            >
                <div className="space-y-4">
                    <div>
                        <TextInput
                            label={'Voting Place Name'}
                            value={addEditVotingPlace?.votingPlaceName || ""}
                            onChange={(e) =>
                                setAddEditVotingPlace((prev) => ({
                                    ...prev,
                                    votingPlaceName: e.target.value,
                                }))
                            }
                        />
                    </div>

                    <div>
                        <TextInput
                            label={'Voting Place Address'}
                            value={addEditVotingPlace?.votingPlaceAddress || ""}
                            onChange={(e) =>
                                setAddEditVotingPlace((prev) => ({
                                    ...prev,
                                    votingPlaceAddress: e.target.value,
                                }))
                            }
                        />
                    </div>
                </div>
            </AddEditModal>
        </div>
    );
};

export default VotingAreasTable;