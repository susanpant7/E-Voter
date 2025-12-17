import {createFileRoute, Outlet, redirect} from '@tanstack/react-router';
import {useAuthStore} from "../../stores/authStore.ts";

export const Route = createFileRoute('/_protected')({
    // This runs before the component (or any child route) is loaded
    beforeLoad: async () => {
        const user = useAuthStore.getState().user;
        if (!user) {
            throw redirect({
                to: '/',
            })
        }
    },

    component: ProtectedLayout,
});

function ProtectedLayout() {
    return (
        <div className="protected-layout flex flex-col min-h-screen">
            {/* You can add protected-only UI here, like a 
                Sidebar or a User-specific dashboard header.
            */}
            <div className="container mx-auto px-4 py-6">
                <Outlet />
            </div>
        </div>
    );
}
