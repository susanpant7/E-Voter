export interface ProvinceInfo {
    provinceId: number;
    provinceName: string;
    provinceCode: string;
}
export interface ProvinceAddRequest {
    provinceName: string;
    provinceCode?: string;
}
export interface ProvinceUpdateRequest {
    provinceId: number;
    provinceName: string;
    provinceCode?: string;
}

export interface DistrictInfo {
    districtId: number;
    districtName: string;
    districtCode: string;
    provinceId: number;
}
export interface DistrictAddRequest {
    districtName: string;
    districtCode?: string;
    provinceId: number;
}

export interface DistrictUpdateRequest {
    districtId: number;
    districtName: string;
    districtCode?: string;
}

export interface MunicipalityInfo {
    municipalityId: number;
    municipalityName: string;
    municipalityCode: string;
    municipalityType: MunicipalityType;
    districtId: number;
}
export const MunicipalityType = {
    Metropolitan: 1,
    SubMetropolitan: 2,
    Municipality: 3,
    Rural: 4,
} as const;

export type MunicipalityType =
    (typeof MunicipalityType)[keyof typeof MunicipalityType];
export const MunicipalityTypeOptions = [
    { label: 'Metropolitan', value: '1' },
    { label: 'Sub-Metropolitan', value: '2' },
    { label: 'Municipality', value: '3' },
    { label: 'Rural', value: '4' },
];
export interface MunicipalityAddRequest {
    municipalityName: string;
    municipalityType: MunicipalityType;
    municipalityCode?: string;
    districtId: number;
}
export interface MunicipalityUpdateRequest {
    municipalityId: number;
    municipalityName: string;
    municipalityType: MunicipalityType;
    municipalityCode?: string;
    districtId: number;
}

export interface WardInfo {
    wardId: number;
    wardName: string;
    wardNumber: number;
    municipalityId: number;
}
export interface WardAddRequest {
    wardName: string;
    wardNumber: number;
    municipalityId: number;
}

export interface WardUpdateRequest {
    wardId: number;
    wardName: string;
    wardNumber: number;
    municipalityId: number;
}

export interface VotingPlaceInfo {
    votingPlaceId: number;
    votingPlaceName: string;
    votingPlaceAddress: string;
    wardId: number;
}
export interface VotingPlaceAddRequest {
    votingPlaceName: string;
    votingPlaceAddress?: string;
    wardId: number;
}

export interface VotingPlaceUpdateRequest {
    votingPlaceId: number;
    votingPlaceName: string;
    votingPlaceAddress?: string;
    wardId: number;
}
