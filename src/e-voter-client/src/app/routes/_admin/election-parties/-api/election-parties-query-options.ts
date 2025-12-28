import {type QueryClient, queryOptions} from "@tanstack/react-query";
import {
    addElectionParty, deleteElectionParty,
    getElectionParties,
    getElectionPartyDetail, updateElectionParty
} from "./election-party.api.ts";
import type {ElectionPartyDetail} from "./election-party.types.ts";

export const getElectionPartiesQueryOptions = () => {
    return queryOptions({
        queryKey: ["election-parties"],
        queryFn: async () => {
            const data = await getElectionParties();
            console.log("Parties loaded successfully");
            return data;
        },
    })
}
export const getElectionPartyDetailQueryOptions = (id:number) => {
    return queryOptions({
        queryKey: ["electionParties",id],
        queryFn: () => getElectionPartyDetail(id),
    })
}

export const addElectionPartyMutationOptions = () => {
    return {
        mutationFn: (payload: ElectionPartyDetail) => addElectionParty(payload),
        onSuccess: () => {
        },
    };
};

export const updateElectionPartyMutationOptions = () => {
    return {
        mutationFn: ({ id, payload }: { id: number; payload: ElectionPartyDetail }) =>
            updateElectionParty(id, payload),        
        onSuccess: () => {
        },
    };
};

export const deleteElectionPartyMutationOptions = (queryClient: QueryClient) => {
    return {
        mutationFn: ({ id }: { id: number }) =>
            deleteElectionParty(id),
        onSuccess: () => {
            queryClient.invalidateQueries({ queryKey: ['election-parties'] });
        },
    };
};