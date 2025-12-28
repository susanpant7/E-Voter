import {type QueryClient, queryOptions} from "@tanstack/react-query";
import {
    addDistrict, addMunicipality,
    addProvince, addVotingPlace, addWard, deleteDistrict, deleteMunicipality, deleteProvince,
    deleteVotingPlace, deleteWard,
    getDistrictsByProvinceId,
    getMunicipalitiesByDistrictId,
    getProvinces,
    getVotingPlacesByWardId,
    getWardsByMunicipalityId, updateDistrict, updateMunicipality, updateProvince, updateVotingPlace, updateWard
} from "./voting-place.api.ts";
import type {
    DistrictAddRequest, DistrictUpdateRequest,
    MunicipalityAddRequest, MunicipalityUpdateRequest, ProvinceAddRequest, ProvinceUpdateRequest,
    VotingPlaceAddRequest, VotingPlaceUpdateRequest, WardAddRequest,
    WardUpdateRequest
} from "./voting-place.types.ts";

export const queryKeys = {
    provinces: ["provinces"] as const,
    districts: (provinceId: number) => ["districts", provinceId] as const,
    municipalities: (districtId: number) => ["municipalities", districtId] as const,
    wards: (municipalityId: number) => ["wards", municipalityId] as const,
    votingPlaces: (wardId: number) => ["voting-places", wardId] as const,
};

export const getProvincesQueryOptions = () => {
    return queryOptions({
        queryKey: ["provinces"],
        queryFn: async () => {
            const data = await getProvinces();
            console.log("Provinces loaded successfully");
            return data;
        },
    });
};
export const addProvinceMutationOptions = (queryClient: QueryClient) => {
    return {
        mutationFn: (payload: ProvinceAddRequest) =>
            addProvince(payload),
        onSuccess: () => {
            alert(1)
            queryClient.invalidateQueries({ queryKey: queryKeys.provinces });
        },
        onError: () => {
            alert()
        }
    };
};
export const updateProvinceMutationOptions = (queryClient: QueryClient) => {
    return {
        mutationFn: (payload: ProvinceUpdateRequest) =>
            updateProvince(payload),
        onSuccess: () => {
            queryClient.invalidateQueries({ queryKey: queryKeys.provinces });
        },
    };
};
export const deleteProvinceMutationOptions = (queryClient: QueryClient) => {
    return {
        mutationFn: ({ id }: { id: number }) =>
            deleteProvince(id),
        onSuccess: () => {
            queryClient.invalidateQueries({ queryKey: queryKeys.provinces });
        },
    };
};


export const getDistrictsByProvinceIdQueryOptions = (provinceId: number) => {
    return queryOptions({
        queryKey: ["districts", provinceId],
        queryFn: async () => {
            const data = await getDistrictsByProvinceId(provinceId);
            console.log("Districts loaded successfully");
            return data;
        },
        enabled: !!provinceId,
    });
};
export const addDistrictMutationOptions = (
    queryClient: QueryClient,
    provinceId: number
) => {
    return {
        mutationFn: (payload: DistrictAddRequest) =>
            addDistrict(payload),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.districts(provinceId),
            });
        },
    };
};

export const updateDistrictMutationOptions = (
    queryClient: QueryClient,
    provinceId: number
) => {
    return {
        mutationFn: (payload: DistrictUpdateRequest) =>
            updateDistrict(payload),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.districts(provinceId),
            });
        },
    };
};

export const deleteDistrictMutationOptions = (
    queryClient: QueryClient,
    provinceId: number
) => {
    return {
        mutationFn: ({ id }: { id: number }) =>
            deleteDistrict(id),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.districts(provinceId),
            });
        },
    };
};



export const getMunicipalitiesByDistrictIdQueryOptions = (districtId: number) => {
    return queryOptions({
        queryKey: ["municipalities", districtId],
        queryFn: async () => {
            const data = await getMunicipalitiesByDistrictId(districtId);
            console.log("Municipalities loaded successfully");
            return data;
        },
        enabled: !!districtId,
    });
};
export const addMunicipalityMutationOptions = (
    queryClient: QueryClient,
    districtId: number
) => {
    return {
        mutationFn: (payload: MunicipalityAddRequest) =>
            addMunicipality(payload),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.municipalities(districtId),
            });
        },
    };
};

export const updateMunicipalityMutationOptions = (
    queryClient: QueryClient,
    districtId: number
) => {
    return {
        mutationFn: (payload: MunicipalityUpdateRequest) =>
            updateMunicipality(payload),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.municipalities(districtId),
            });
        },
    };
};

export const deleteMunicipalityMutationOptions = (
    queryClient: QueryClient,
    districtId: number
) => {
    return {
        mutationFn: ({ id }: { id: number }) =>
            deleteMunicipality(id),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.municipalities(districtId),
            });
        },
    };
};


export const getWardsByMunicipalityIdQueryOptions = (municipalityId: number) => {
    return queryOptions({
        queryKey: ["wards", municipalityId],
        queryFn: async () => {
            const data = await getWardsByMunicipalityId(municipalityId);
            console.log("Wards loaded successfully");
            return data;
        },
        enabled: !!municipalityId,
    });
};
export const addWardMutationOptions = (
    queryClient: QueryClient,
    municipalityId: number
) => {
    return {
        mutationFn: (payload: WardAddRequest) =>
            addWard(payload),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.wards(municipalityId),
            });
        },
    };
};

export const updateWardMutationOptions = (
    queryClient: QueryClient,
    municipalityId: number
) => {
    return {
        mutationFn: (payload: WardUpdateRequest) =>
            updateWard(payload),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.wards(municipalityId),
            });
        },
    };
};

export const deleteWardMutationOptions = (
    queryClient: QueryClient,
    municipalityId: number
) => {
    return {
        mutationFn: ({ id }: { id: number }) =>
            deleteWard(id),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.wards(municipalityId),
            });
        },
    };
};


export const getVotingPlacesByWardIdQueryOptions = (wardId: number) => {
    return queryOptions({
        queryKey: ["voting-places", wardId],
        queryFn: async () => {
            const data = await getVotingPlacesByWardId(wardId);
            console.log("Voting places loaded successfully");
            return data;
        },
        enabled: !!wardId,
    });
};
export const addVotingPlaceMutationOptions = (
    queryClient: QueryClient,
    wardId: number
) => {
    return {
        mutationFn: (payload: VotingPlaceAddRequest) =>
            addVotingPlace(payload),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.votingPlaces(wardId),
            });
        },
    };
};

export const updateVotingPlaceMutationOptions = (
    queryClient: QueryClient,
    wardId: number
) => {
    return {
        mutationFn: (payload: VotingPlaceUpdateRequest) =>
            updateVotingPlace(payload),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.votingPlaces(wardId),
            });
        },
    };
};

export const deleteVotingPlaceMutationOptions = (
    queryClient: QueryClient,
    wardId: number
) => {
    return {
        mutationFn: ({ id }: { id: number }) =>
            deleteVotingPlace(id),
        onSuccess: () => {
            queryClient.invalidateQueries({
                queryKey: queryKeys.votingPlaces(wardId),
            });
        },
    };
};

