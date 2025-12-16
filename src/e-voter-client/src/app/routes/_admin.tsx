import {createFileRoute, Outlet, redirect} from '@tanstack/react-router'
import {getToken} from "../../auth/authProvider.ts";
import {userIsAdmin} from "../../auth/jwt.ts";

export const Route = createFileRoute('/_admin')({
  component: RouteComponent,
  beforeLoad: async () => {
    const token = await getToken();
    
    if (!token) {
      throw redirect({
        to: '/',
      });
    }
    
  },
})

function RouteComponent() {
  return <div className="protected-layout">
    This is only for admin .... Welcome admin
    <Outlet />
  </div>
}
