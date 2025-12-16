import {createFileRoute, redirect, Outlet, useParams} from '@tanstack/react-router';
import {getToken} from "../../auth/authProvider.ts";

export const Route = createFileRoute('/_protected')({
    beforeLoad: async () => {
        const params = useParams({from:'/'});
        const target = params.target;
        console.log("...>>>>"+target);
        const token = await getToken();

        if (!token) {
            throw redirect({
                to: '/',
            });
        }
    },

    component: () => (
        <div className="protected-layout">
            <Outlet />
        </div>
    ),
});
