import type {
    DistrictAddRequest,
    DistrictInfo, DistrictUpdateRequest, MunicipalityAddRequest,
    MunicipalityInfo, MunicipalityUpdateRequest,
    ProvinceAddRequest,
    ProvinceInfo, ProvinceUpdateRequest, VotingPlaceAddRequest,
    VotingPlaceInfo, VotingPlaceUpdateRequest, WardAddRequest,
    WardInfo, WardUpdateRequest
} from "./voting-place.types.ts";
import eVoterApi from "../../../../../api/e-voter-api.ts";


export const getProvinces = async () : Promise<ProvinceInfo[]> => {
    return eVoterApi.get<any,ProvinceInfo[]>("/api/voting-places/provinces");
};
export const addProvince = (payload: ProvinceAddRequest) => {
    return eVoterApi.post<number>(
        "/api/voting-places/provinces",
        payload
    );
};
export const updateProvince = (payload: ProvinceUpdateRequest) => {
    return eVoterApi.put<boolean>(
        "/api/voting-places/provinces",
        payload
    );
};
export const deleteProvince = (id: number) => {
    return eVoterApi.delete<boolean>(
        `/api/voting-places/provinces/${id}`
    );
};

export const getDistrictsByProvinceId = async (provinceId: number) : Promise<DistrictInfo[]> => {
    return eVoterApi.get<any,DistrictInfo[]>(`/api/voting-places/provinces/${provinceId}/districts`);
};
export const addDistrict = async (payload: DistrictAddRequest) => {
    return eVoterApi.post<number>(
        "/api/voting-places/districts",
        payload
    );
};
export const updateDistrict = async (payload: DistrictUpdateRequest) => {
    return eVoterApi.put<boolean>(
        "/api/voting-places/districts",
        payload
    );
};
export const deleteDistrict = async (id: number) => {
    return eVoterApi.delete<boolean>(
        `/api/voting-places/districts/${id}`
    );
};

export const getMunicipalitiesByDistrictId = async (districtId: number) : Promise<MunicipalityInfo[]> => {
    return eVoterApi.get<any,MunicipalityInfo[]>(`/api/voting-places/districts/${districtId}/municipalities`);
};
export const addMunicipality = async (payload: MunicipalityAddRequest) => {
    return eVoterApi.post<number>(
        "/api/voting-places/municipalities",
        payload
    );
};
export const updateMunicipality = async (payload: MunicipalityUpdateRequest) => {
    return eVoterApi.put<boolean>(
        "/api/voting-places/municipalities",
        payload
    );
};
export const deleteMunicipality = async (id: number) => {
    return eVoterApi.delete<boolean>(
        `/api/voting-places/municipalities/${id}`
    );
};

export const getWardsByMunicipalityId = async (municipalityId: number) : Promise<WardInfo[]> => {
    return eVoterApi.get<any,WardInfo[]>(`/api/voting-places/municipalities/${municipalityId}/wards`);
};
export const addWard = async (payload: WardAddRequest) => {
    return eVoterApi.post<number>(
        "/api/voting-places/wards",
        payload
    );
};

export const updateWard = async (payload: WardUpdateRequest) => {
    return eVoterApi.put<boolean>(
        "/api/voting-places/wards",
        payload
    );
};

export const deleteWard = async (id: number) => {
    return eVoterApi.delete<boolean>(
        `/api/voting-places/wards/${id}`
    );
};


export const getVotingPlacesByWardId = async (wardId: number) : Promise<VotingPlaceInfo[]> => {
    return eVoterApi.get<any,VotingPlaceInfo[]>(`/api/voting-places/wards/${wardId}/voting-places`);
};
export const addVotingPlace = async (payload: VotingPlaceAddRequest) => {
    return eVoterApi.post<number>(
        "/api/voting-places",
        payload
    );
};

export const updateVotingPlace = async (payload: VotingPlaceUpdateRequest) => {
    return eVoterApi.put<boolean>(
        "/api/voting-places",
        payload
    );
};

export const deleteVotingPlace = async (id: number) => {
    return eVoterApi.delete<boolean>(
        `/api/voting-places/${id}`
    );
};

