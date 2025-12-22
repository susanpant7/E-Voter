import {updateMediaFile, uploadMediaFile} from "./media-file.api.ts";

export const upsertMediaFileMutationOptions = () => {
    return {
        mutationFn: async ({ formData, id }: { formData: FormData; id: number }) => {
            if (id != 0) {
                await updateMediaFile(id, formData);
                return id; // Return the ID so the type is Promise<number>
            }
            // uploadMediaFile already returns Promise<number>
            return await uploadMediaFile(formData);
        },
        onSuccess: (mediaFileId: number) => {
            console.log("Media file uploaded, id:", mediaFileId);
        },
        onError: (error: any) => {
            console.error("Upload failed", error);
        }
    };
};