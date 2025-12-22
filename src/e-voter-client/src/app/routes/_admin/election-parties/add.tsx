import {createFileRoute, useNavigate} from "@tanstack/react-router";
import {ElectionPartyForm} from "../../../../componenets/election-parties/AddEditParty.tsx";
import {useMutation} from "@tanstack/react-query";
import type {ElectionPartyDetail} from "../../../../api/election-parties/election-party.types.ts";
import {addElectionPartyMutationOptions} from "../../../../api/election-parties/election-parties-query-options.ts";

export const Route = createFileRoute('/_admin/election-parties/add')({
    component: AddElectionPartyForm,
})

function AddElectionPartyForm(){
    const mutation = useMutation(addElectionPartyMutationOptions());
    const navigate = useNavigate();

    const createParty = async (formData:ElectionPartyDetail) => {
        try {
            await mutation.mutateAsync(formData);
            await navigate({ to: '/election-parties' as any })
        } catch (error: any) {
        }
    }
    return(
        <>
            {/* Show a spinner / saving message when the mutation is in progress */}
            {mutation.isPending && (
                <div className="flex items-center gap-2 mb-4 text-blue-600 font-medium">
                    <svg
                        className="w-5 h-5 animate-spin"
                        xmlns="http://www.w3.org/2000/svg"
                        fill="none"
                        viewBox="0 0 24 24"
                    >
                        <circle
                            className="opacity-25"
                            cx="12"
                            cy="12"
                            r="10"
                            stroke="currentColor"
                            strokeWidth="4"
                        ></circle>
                        <path
                            className="opacity-75"
                            fill="currentColor"
                            d="M4 12a8 8 0 018-8v4l3-3-3-3v4a8 8 0 00-8 8h4l-3 3 3 3h-4z"
                        ></path>
                    </svg>
                    Saving election party...
                </div>
            )}

            <ElectionPartyForm onSubmit={createParty} />
        </>
        
    )
}

