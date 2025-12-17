import axios from 'axios';
import {showErrorNotification} from "../componenets/UI/Toast.tsx";
import {EndPoints} from "./endpoint-routes.ts";
import type {ApiResponse} from "./api-response.ts";

const eVoterApi = axios.create({
    baseURL: import.meta.env.VITE_API_URL || 'http://localhost:5244',
    headers: { 'Content-Type': 'application/json' },
    timeout: 10000,
    withCredentials: true,
});

// Request interceptor
eVoterApi.interceptors.request.use(
    async (config) => {
        return config;
    },
    (error) => Promise.reject(error)
);

// Response interceptor
eVoterApi.interceptors.response.use(
    (response) => {
        const data = response.data;
        if (isApiResponse(data)) {
            if (!data.success) {
                const errorMessage = data.title || "An error occurred";

                if (response.config.url !== EndPoints.GetUserInfo) {
                    showErrorNotification(errorMessage);
                }

                return Promise.reject(new Error(errorMessage));
            }

            return data.data;
        }

        return data;
    },
    (error) => {
        const { response } = error;

        if (response) {
            const { status, data, config } = response;

            const skipNotification = config.url === EndPoints.GetUserInfo;

            if (!skipNotification) {
                if (isApiResponse(data)) {
                    showErrorNotification(data.title || `Error: ${status}`);
                } else {
                    showErrorNotification(`Request failed with status ${status}`);
                }
            }

        } else if (error.request) {
            showErrorNotification("Network error. Please check your connection.");
        } else {
            showErrorNotification("An unexpected error occurred.");
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
