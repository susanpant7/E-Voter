import axios from 'axios';
import {useAuthStore} from "../stores/authStore.ts";
import type {ApiResponse} from "./apiResponse.ts";
import {refreshToken} from "../auth/authProvider.ts";

const eVoterApi = axios.create({
    baseURL: import.meta.env.VITE_API_URL || 'http://localhost:5244',
    headers: { 'Content-Type': 'application/json' },
    timeout: 10000,
    withCredentials: true,
});

// Request interceptor
eVoterApi.interceptors.request.use(
    async (config) => {
        const { token } = useAuthStore.getState();
        if (token) {
            config.headers.Authorization = `Bearer ${token}`;
        }
        return config;
    },
    (error) => Promise.reject(error)
);

// Response interceptor
eVoterApi.interceptors.response.use(
    (response) =>
    {
        const data = response.data;

        if (isApiResponse(data)) {
            if (!data.success) {
                return Promise.reject(new Error(data.title || 'API Error'));
            }
            return data.data;
        }

        // return raw response if it's not ApiResponse
        return data;
    },
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

function isApiResponse<T>(data: any): data is ApiResponse<T> {
    return (
        data &&
        typeof data === 'object' &&
        'success' in data &&
        'data' in data &&
        'title' in data &&
        'status' in data &&
        'timestamp' in data
    );
}
export default eVoterApi;
