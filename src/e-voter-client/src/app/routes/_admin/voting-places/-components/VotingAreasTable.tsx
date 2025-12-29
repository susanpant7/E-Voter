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
import {isEmpty} from "../../../../../utils/input-validators.ts";

interface VotingAreasTableProps {
    wardInfo: WardInfo;
    provinceName: string;
    districtName: string;
    municipalityName: string;
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
        if(isEmpty(addEditVotingPlace.votingPlaceName) || isEmpty(addEditVotingPlace.votingPlaceAddress)){
            return;
        }
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
            <div className="border rounded-md bg-slate-50">
                <div className="flex items-center justify-start gap-3 px-4 py-2 border-b border-slate-200 bg-slate-50 rounded-t-md">
                    {/* Title */}
                    <h3 className="text-xs sm:text-sm font-semibold text-slate-800 tracking-tight flex-1 truncate flex items-center gap-1">
                        <span className="inline-block animate-pulse shrink-0">📍</span>
                        <span className="truncate">
                          Voting Places in Province: <span className="font-medium">{props.provinceName}</span> | 
                          District: <span className="font-medium">{props.districtName}</span> | 
                          Municipality: <span className="font-medium">{props.municipalityName}</span> | 
                          Ward: <span className="font-medium">{props.wardInfo.wardName}</span>
                        </span>
                    </h3>

                    {/* Add Button */}
                    <AddButton label="Add Voting Place" onClick={onAddButtonClick} />
                </div>




                <div className={data?.length ? "max-h-[200px] overflow-y-auto" : ""}>
                    <table className="w-full">
                        <thead className="bg-slate-100 text-sm">
                        <tr>
                            <th className="px-4 py-2 text-left">Voting Place Name</th>
                            <th className="px-4 py-2 text-left">Address</th>
                            <th className="px-4 py-2"></th>
                        </tr>
                        </thead>

                        <tbody>
                        {(!data || data.length === 0) && (
                            <tr>
                                <td colSpan={3} className="py-8 text-center text-gray-500">
                                    No voting places
                                </td>
                            </tr>
                        )}

                        {data?.map((place) => {
                            return (
                                <tr
                                    key={place.votingPlaceId}
                                    className="border-b hover:bg-slate-100 transition"
                                >
                                    <td className="px-4 py-2 font-medium">
                                        {place.votingPlaceName}
                                    </td>
                                    <td className="px-4 py-2 text-sm">
                                        {place.votingPlaceAddress}
                                    </td>
                                    <td className="px-4 py-2">
                                        <div className="flex gap-2">
                                            <EditButton onClick={() => onEditButtonClick(place)} />
                                            <DeleteButton onClick={() => onDeleteButtonClick(place)} />
                                        </div>
                                    </td>
                                </tr>
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