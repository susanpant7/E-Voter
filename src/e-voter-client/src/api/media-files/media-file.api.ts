import eVoterApi from "../e-voter-api.ts";

export const uploadMediaFile = async (formData: FormData) : Promise<number> => {
    return eVoterApi.post<any,number>("/api/media-files/upload", formData);
};

export const updateMediaFile = async (id: number, formData: FormData): Promise<void> => {
    await eVoterApi.put(`/api/media-files/${id}`, formData);
};