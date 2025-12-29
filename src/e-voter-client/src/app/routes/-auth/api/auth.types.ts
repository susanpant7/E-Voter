export interface LoginPayload {
    username: string;
    password: string;
}

export const ROLE_NAMES = {
    ADMIN: "ADMIN",
    USER: "USER",
    SUPER_ADMIN: "SUPER_ADMIN",
}
