import type {ElectionPartyDetail, ElectionPartySummary, UpsertElectionParty} from "./election-party.types.ts";
import eVoterApi from "../e-voter-api.ts";

export const getElectionParties = async () : Promise<ElectionPartySummary[]> => {
    return eVoterApi.get<any,ElectionPartySummary[]>("/api/election-parties");
};

export const getElectionPartyDetail = async (id:number) : Promise<ElectionPartyDetail> => {
    return eVoterApi.get<any,ElectionPartyDetail>(`/api/election-parties/${id}`);
};

export const addElectionParty = async (payload: ElectionPartyDetail) => {
    return eVoterApi.post<number>("/api/election-parties", payload);
};

export const updateElectionParty = async (id: number, payload: UpsertElectionParty) => {
    return eVoterApi.put<boolean>(`/api/election-parties/${id}`, payload);
};

export const deleteElectionParty = async (id: number) => {
    return eVoterApi.delete<boolean>(`/api/election-parties/${id}`);
};
