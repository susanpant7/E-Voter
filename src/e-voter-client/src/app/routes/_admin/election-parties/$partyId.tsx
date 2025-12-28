import {createFileRoute, useNavigate} from '@tanstack/react-router'
import {useMutation, useQuery} from "@tanstack/react-query";
import {ElectionPartyForm} from "./-components/AddEditParty.tsx";
import {
    getElectionPartyDetailQueryOptions,
    updateElectionPartyMutationOptions
} from "./-api/election-parties-query-options.ts";
import type {ElectionPartyDetail} from "./-api/election-party.types.ts";


export const Route = createFileRoute('/_admin/election-parties/$partyId')({
  component: RouteComponent,
})

function RouteComponent() {
    const { partyId } = Route.useParams(); // Access the dynamic parameter
    const { data, isPending } = useQuery(getElectionPartyDetailQueryOptions(partyId));
    const mutation = useMutation(updateElectionPartyMutationOptions());
    const navigate = useNavigate();
    if (isPending) {
        return <div className="p-6">Loading election party detail...</div>;
    }
    
    const updateParty = async (partyId:number,data:ElectionPartyDetail) => {
        try {
            await mutation.mutateAsync({id:partyId,payload:data});
            await navigate({ to: '/election-parties' as any })
        } catch (error: any) {
        }
    }
    return (
        <>
            <ElectionPartyForm
                initialData={data}
                onSubmit={(data) => updateParty(partyId, data)}
            />
        </>
    )
}
