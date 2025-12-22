import {createFileRoute, Outlet} from '@tanstack/react-router'
import {adminGuard} from "../../utils/auth-guards.ts";

export const Route = createFileRoute('/_admin')({
  component: RouteComponent,
  beforeLoad: ({ location }) => adminGuard(location)
})

function RouteComponent() {
  return <div className="protected-layout">
    <Outlet />
  </div>
}
