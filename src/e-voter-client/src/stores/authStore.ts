import { create } from 'zustand';

export type User = {
    id: string
    email: string
    roles: string[]
}

type AuthState = {
    user: User | null;
    isAuthenticated: boolean;
    setUser: (user: User | null) => void;
};

export const useAuthStore = create<AuthState>((set) => ({
    user: null,
    isAuthenticated: false,
    setUser: (user) =>
        set({
            user,
            isAuthenticated: !!user,
        }),
}));
