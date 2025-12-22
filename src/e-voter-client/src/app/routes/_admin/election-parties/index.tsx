import {createFileRoute, Link} from '@tanstack/react-router'
import {useMutation, useQuery, useQueryClient} from "@tanstack/react-query";
import {
  deleteElectionPartyMutationOptions,
  getElectionPartiesQueryOptions
} from "../../../../api/election-parties/election-parties-query-options.ts";

export const Route = createFileRoute('/_admin/election-parties/')({
  component: RouteComponent,
})

function RouteComponent() {
  const { data, isPending } = useQuery(getElectionPartiesQueryOptions());
  const queryClient = useQueryClient();

  const mutation = useMutation(deleteElectionPartyMutationOptions(queryClient));

  if (isPending) {
    return <div className="p-6">Loading election parties...</div>;
  }

  const handleDelete = async (id: number) => {
    const confirmed = window.confirm(
        "Are you sure you want to delete this election party? This action cannot be undone."
    );

    if (!confirmed) return;

    try {
      await mutation.mutateAsync({ id });
    } catch (err) {
    }
  }
  
  return (
      <div className="p-6 space-y-4 bg-gray-50 dark:bg-gray-900 min-h-screen">
        {/* Header */}
        <div className="flex items-center justify-between">
          <h1 className="text-xl font-semibold text-gray-900 dark:text-gray-100">
            Election Parties
          </h1>

          {/* Add button (UI only) */}
          <Link to="add" 
                className="
                  px-4 py-2 rounded
                  bg-blue-600 hover:bg-blue-700
                  text-white
                  dark:bg-blue-500 dark:hover:bg-blue-600
                "
          >
            + Add Party
          </Link>

          
        </div>

        {/* Table */}
        <div className="overflow-x-auto border rounded
                  border-gray-200 dark:border-gray-700
                  bg-white dark:bg-gray-800">
          <table className="w-full border-collapse">
            <thead className="bg-gray-100 dark:bg-gray-700">
            <tr>
              
              <th className="p-3 text-left border-b
                         border-gray-200 dark:border-gray-600
                         text-gray-700 dark:text-gray-200">
                Name
              </th>
              <th className="p-3 text-left border-b
                         border-gray-200 dark:border-gray-600
                         text-gray-700 dark:text-gray-200">
                Leader
              </th>
              <th className="p-3 text-left border-b w-32
                       border-gray-200 dark:border-gray-600
                       text-gray-700 dark:text-gray-200">
                Action
              </th>
            </tr>
            </thead>

            <tbody>
            {data?.map((party) => (
                <tr
                    key={party.id}
                    className="
                      hover:bg-gray-50 dark:hover:bg-gray-700
                    "
                >

                  <td className="p-3 border-b border-gray-200 dark:border-gray-700
                           font-medium text-gray-900 dark:text-gray-100">
                    {party.name}
                  </td>

                  <td className="p-3 border-b border-gray-200 dark:border-gray-700
                           text-gray-700 dark:text-gray-300">
                    {party.leaderName || "—"}
                  </td>

                  <td className="p-3 border-b border-gray-200 dark:border-gray-700">
                    <div className="flex items-center gap-3">
                      <Link
                          className="text-blue-600 hover:underline dark:text-blue-400"
                          to="/election-parties/$partyId"
                          params={{ partyId: party.id }}
                      >
                        Edit
                      </Link>

                      {/* Delete icon */}
                      <button
                          type="button"
                          aria-label="Delete party"
                          onClick={() => handleDelete(party.id)}
                          className="
                              group cursor-pointer
                              p-1.5 rounded
                              text-red-600
                              hover:text-red-700
                              hover:bg-red-50
                              active:bg-red-100
                              active:scale-95
                              transition
                              duration-150
                              ease-in-out
                              focus:outline-none
                              focus:ring-2
                              focus:ring-red-500
                              focus:ring-offset-1
                              dark:text-red-400
                              dark:hover:text-red-300
                              dark:hover:bg-red-900/20
                              dark:active:bg-red-900/30
                            "
                      >
                        <svg
                            xmlns="http://www.w3.org/2000/svg"
                            viewBox="0 0 24 24"
                            fill="none"
                            stroke="currentColor"
                            strokeWidth="2"
                            className="
                                  w-5 h-5
                                  transition-transform
                                  group-hover:scale-110
                                "
                        >
                          <path
                              strokeLinecap="round"
                              strokeLinejoin="round"
                              d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6M9 7h6m2 0H7m3-3h4a1 1 0 011 1v1H9V5a1 1 0 011-1z"
                          />
                        </svg>
                      </button>
                    </div>
                  </td>


                </tr>
            ))}

            {data?.length === 0 && (
                <tr>
                  <td
                      colSpan={4}
                      className="p-4 text-center
                         text-gray-500 dark:text-gray-400"
                  >
                    No election parties found
                  </td>
                </tr>
            )}
            </tbody>
          </table>
        </div>
      </div>

  );
}
