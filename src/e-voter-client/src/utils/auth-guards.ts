import { redirect } from '@tanstack/react-router';
import { useAuthStore } from '../stores/authStore';
import {ROLE_NAMES} from "../types/role-names.ts";

export const adminGuard = (location: any) => {
    const { user } = useAuthStore.getState();

    const isAuthorized = user?.roles.some(role =>
        [ROLE_NAMES.ADMIN, ROLE_NAMES.SUPER_ADMIN].includes(role)
    );

    if (!isAuthorized) {
        throw redirect({
            to: '/',
            search: { redirect: location.href },
        });
    }
};