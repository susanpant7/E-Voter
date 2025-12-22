export interface ElectionPartySummary {
    id: number;
    name: string;
    leaderName?: string;
    logo?: string; // base64
    logoContentType?: string;
}

export interface ElectionPartyDetail {
    id: number;
    name: string;
    abbreviation: string;
    description?: string;

    leaderName?: string;
    founderName?: string;

    foundedOn: string;        // ISO date string
    registeredOn?: string;    // ISO date string | undefined

    isRecognizedNationally: boolean;
    status: PartyStatus;

    ideology?: string;
    politicalSpectrum?: string;

    officialWebsite?: string;
    contactEmail?: string;
    contactPhone?: string;

    headquartersAddress?: string;

    logoFileId?: number | null;
    logoFileName?: string | null;
}

export const PartyStatus = {
    Active: 1,
    Inactive: 2,
    Suspended: 3,
} as const;

export type PartyStatus =
    typeof PartyStatus[keyof typeof PartyStatus];

export const  getPartyStatusLabel = (status: PartyStatus) => {
    switch (status) {
        case PartyStatus.Active:
            return "Active";
        case PartyStatus.Inactive:
            return "Inactive";
        case PartyStatus.Suspended:
            return "Suspended";
    }
}

export interface UpsertElectionParty {
    name: string;
    abbreviation: string;
    leaderName?: string;
    foundedOn: string;
    status: number;
    logo?: string; // base64
    logoContentType?: string;
}
