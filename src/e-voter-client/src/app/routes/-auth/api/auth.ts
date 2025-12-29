import type {LoginPayload} from "./auth.types.ts";
import {useAuthStore, type User} from "../../../../stores/authStore.ts";
import eVoterApi from "../../../../api/e-voter-api.ts";
import {EndPoints} from "../../../../api/endpoint-routes.ts";
import {showSuccessNotification} from "../../../../componenets/UI/Toast.tsx";

export async function loadCurrentUser() {
    const { setUser } = useAuthStore.getState();
    
    try {
        const user:User = await eVoterApi.get(EndPoints.GetUserInfo);
        setUser(user);
    } catch (err) {
        setUser(null);
    }
}

export async function loginApi(payload: LoginPayload): Promise<void> {
    await eVoterApi.post(EndPoints.Login, payload)
    await loadCurrentUser();
    showSuccessNotification("Login successfully");
}

export const logoutApi = async () : Promise<void> => {
    await eVoterApi.post(EndPoints.Logout, {});
    useAuthStore.getState().setUser(null);
    showSuccessNotification("Logout successfully");
}