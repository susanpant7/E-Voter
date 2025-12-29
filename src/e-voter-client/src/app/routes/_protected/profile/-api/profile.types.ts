export interface Profile {
    voterId: string;
    voterCardNumber: string;
    mobileNumber: string;

    // Personal info
    firstName: string;
    middleName?: string | null;
    lastName: string;
    gender: string;

    // Status
    isVerified: boolean;
    isActive: boolean;
    registeredAt: string;

    // Voting location
    votingPlaceName: string;
    votingPlaceAddress: string;

    wardName: string;
    wardNumber: number;

    municipalityName: string;
    municipalityType: number;

    districtName: string;
    districtCode: string;

    provinceName: string;
}