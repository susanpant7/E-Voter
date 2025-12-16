// src/utils/jwt.ts
import { jwtDecode } from 'jwt-decode';
import {ClaimField} from "./ClaimProperty.ts";

export interface JwtPayload {
    exp: number;
    iss: string;
    aud: string;
    [key: string]: any;
}
/**
 * Check if a JWT token is expired
 */
export const isTokenExpired = (token: string): boolean => {
    if (!token) return true;

    try {
        const { exp } = jwtDecode<JwtPayload>(token);
        if (!exp) return true;
        return Date.now() >= exp * 1000;
    } catch (err) {
        console.error('Invalid token:', err);
        return true;
    }
};

export const userIsAdmin = (token: string): boolean => {
    try {
        const decoded = jwtDecode<JwtPayload>(token);

        const rawRoles = decoded[ClaimField.ROLE];

        if (!rawRoles) return false;

        const roles = Array.isArray(rawRoles) ? rawRoles : [rawRoles];

        return roles.includes('ADMIN');
    } catch {
        return false;
    }
};