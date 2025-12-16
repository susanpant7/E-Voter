import {useAuthStore} from "../stores/authStore.ts";
import {isTokenExpired} from "./jwt.ts";
import axios from "axios";
import eVoterApi from "../api/axios.ts";

export const publicAuthApi = axios.create({
    baseURL: import.meta.env.AUTH_API_URL || 'http://localhost:5077',
    headers: { 'Content-Type': 'application/json' },
    timeout: 10000,
    withCredentials: true,
});

export const privateAuthApi = axios.create({
    baseURL: import.meta.env.AUTH_API_URL || 'http://localhost:5077',
    headers: { 'Content-Type': 'application/json' },
    timeout: 10000,
    withCredentials: true,
});

privateAuthApi.interceptors.response.use(
    (response) => response,
    async (error) => {
        const originalRequest = error.config;
        if (error.response.status === 401 && !originalRequest._retry) {
            originalRequest._retry = true;
            try {
                const newAccessToken = await refreshToken();
                originalRequest.headers.Authorization = `Bearer ${newAccessToken}`;
                return eVoterApi(originalRequest);
            } catch (refreshError) {
                console.error('Refresh token failed:', refreshError);
                window.location.href = "/";
                return Promise.reject(refreshError);
            }
        }
        return Promise.reject(error);
    }
);


export const getToken = async (): Promise<string | null> => {
    const { token, logout } = useAuthStore.getState();

    // No token → not logged in
    if (!token) return null;

    // Token still valid → use it
    if (!isTokenExpired(token)) {
        return token;
    }

    // Token expired → try refresh ONCE
    try {
        const newToken = await refreshToken();
        return newToken;
    } catch (error) {
        logout();
        return null;
    }
};


export const refreshToken = async ():Promise<string> => {
    const response = await publicAuthApi.post('/api/auth/refresh-token');
    const newAccessToken = response.data.data.accessToken;
    useAuthStore.getState().login(newAccessToken);
    return newAccessToken;
}