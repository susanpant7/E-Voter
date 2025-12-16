import {
    AuthLoginEndpoint,
    type LoginPayload,
    type LoginResponse,
    AuthLogoutEndpoint
} from "./authType.ts";
import {privateAuthApi, publicAuthApi} from "../../auth/authProvider.ts";
import {useAuthStore} from "../../stores/authStore.ts";

export async function loginApi(payload: LoginPayload): Promise<void> {
    try {
        const { data } = await publicAuthApi.post<LoginResponse>(AuthLoginEndpoint, payload);
        if (!data.success) {
            throw new Error(data.title || 'Login failed');
        }
        useAuthStore.getState().login(data.data.accessToken);
    } catch (err: any) {
        throw new Error(err.response?.data?.message || 'Login failed');
    }
}

export async function logoutApi() {
    try {
        await privateAuthApi.post(AuthLogoutEndpoint);
    } catch (err: any) {
        throw new Error(err.response?.data?.message || 'Issue on logout');
    } finally {
        useAuthStore.getState().logout();
        // localStorage.clear();
        window.location.href = "/";
    }
}
