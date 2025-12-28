import { createFileRoute } from '@tanstack/react-router'
import ProvincesTable from "./-components/ProvincesTable.tsx";

export const Route = createFileRoute('/_admin/voting-places/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
      <div >
          <ProvincesTable />
      </div>
  );
}
