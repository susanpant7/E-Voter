import type {ApiResponse} from "../apiResponse.ts";

export const AuthLoginEndpoint = "/api/auth/login";
export const AuthLogoutEndpoint = "/api/auth/logout";
export interface LoginPayload {
    username: string;
    password: string;
}

export interface LoginResponseData {
    accessToken: string;
    refreshToken: string;
}

export type LoginResponse = ApiResponse<LoginResponseData>;
