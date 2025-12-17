import {useEffect, useState} from "react";
import { useAuthStore } from "../stores/authStore.ts";
import { Link, useNavigate } from "@tanstack/react-router";
import LoginModal from "./auth/LoginModal.tsx";
import { logoutApi } from "../api/auth/auth.ts";
import { getUserNavbarLinks } from "../utils/navbar-links.ts";

export default function Header() {
    const navigate = useNavigate();
    const user = useAuthStore(state => state.user);
    const isAuthenticated = useAuthStore(state => state.isAuthenticated);

    const [modalOpen, setModalOpen] = useState(false);

    const [darkMode, setDarkMode] = useState(() => {
        if (typeof window !== "undefined") {
            return localStorage.getItem("theme") === "dark";
        }
        return false;
    });

    // Sync dark mode class on mount
    useEffect(() => {
        if (darkMode) {
            document.documentElement.classList.add("dark");
        } else {
            document.documentElement.classList.remove("dark");
        }
    }, [darkMode]);
    
    const [loggingOut, setLoggingOut] = useState(false);

    const toggleTheme = () => {
        setDarkMode(prev => {
            const newTheme = !prev;
            if (typeof window !== "undefined") {
                if (newTheme) {
                    document.documentElement.classList.add("dark");
                    localStorage.setItem("theme", "dark");
                } else {
                    document.documentElement.classList.remove("dark");
                    localStorage.setItem("theme", "light");
                }
            }
            return newTheme;
        });
    };

    const handleLogout = async () => {
        setLoggingOut(true);
        try {
            await logoutApi();
            useAuthStore.getState().setUser(null);
            await navigate({ to: "/" as any });
        } catch (err) {
            console.error(err);
        } finally {
            setLoggingOut(false);
        }
    };

    const navLinks = getUserNavbarLinks(user);

    return (
        <header className="bg-white dark:bg-gray-900 shadow-sm border-b border-gray-100 dark:border-gray-800 py-4 sticky top-0 z-50">
            <div className="max-w-7xl mx-auto px-6 flex justify-between items-center">

                {/* LEFT SIDE: Logo & Navigation */}
                <div className="flex items-center gap-10">
                    {/* Logo */}
                    <div className="text-2xl font-black tracking-tighter text-blue-600 dark:text-white uppercase">
                        E-Voter
                    </div>

                    {/* Navbar Links */}
                    <nav className="flex items-center gap-3">
                        {navLinks.map(link => (
                            <Link
                                key={link.label}
                                to={link.path}
                                activeProps={{
                                    className: "!bg-blue-600 !text-white !shadow-lg !shadow-blue-500/40 !scale-105"
                                }}
                                className="flex items-center gap-2 px-4 py-2 rounded-xl bg-gray-50 dark:bg-gray-800 text-gray-600 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-700 transition-all duration-200"
                            >
                                <span className="text-lg">{link.icon || "🔗"}</span>
                                <span className="font-bold text-sm">{link.label}</span>
                            </Link>
                        ))}
                    </nav>
                </div>

                {/* RIGHT SIDE: Theme & Auth (Directly Visible) */}
                <div className="flex items-center gap-4">

                    {/* Theme Toggle Pill */}
                    <div
                        onClick={toggleTheme}
                        className={`w-14 h-7 flex items-center rounded-full p-1 cursor-pointer transition-colors duration-300 ${
                            darkMode ? "bg-gray-700" : "bg-yellow-400"
                        }`}
                    >
                        <div
                            className={`bg-white w-5 h-5 rounded-full shadow-sm flex items-center justify-center text-[10px] transition-transform duration-300 ${
                                darkMode ? "translate-x-7" : "translate-x-0"
                            }`}
                        >
                            {darkMode ? "🌙" : "☀️"}
                        </div>
                    </div>

                    {/* Auth Action Icon */}
                    {isAuthenticated ? (
                        <button
                            onClick={handleLogout}
                            disabled={loggingOut}
                            title="Logout"
                            className="flex items-center justify-center w-10 h-10 rounded-xl bg-red-50 dark:bg-red-900/20 text-red-600 dark:text-red-400 hover:bg-red-600 hover:text-white transition-all duration-300 border border-red-100 dark:border-red-900/30 active:scale-90 cursor-pointer"
                        >
                            {loggingOut ? (
                                <svg className="animate-spin h-5 w-5" viewBox="0 0 24 24">
                                    <circle className="opacity-25" cx="12" cy="12" r="10" stroke="currentColor" strokeWidth="4" fill="none" />
                                    <path className="opacity-75" fill="currentColor" d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z" />
                                </svg>
                            ) : (
                                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" strokeWidth={2} stroke="currentColor" className="w-5 h-5">
                                    <path strokeLinecap="round" strokeLinejoin="round" d="M15.75 9V5.25A2.25 2.25 0 0013.5 3h-6a2.25 2.25 0 00-2.25 2.25v13.5A2.25 2.25 0 007.5 21h6a2.25 2.25 0 002.25-2.25V15m3 0l3-3m0 0l-3-3m3 3H9" />
                                </svg>
                            )}
                        </button>
                    ) : (
                        <button
                            onClick={() => setModalOpen(true)}
                            title="Login"
                            className="flex items-center justify-center w-10 h-10 rounded-xl bg-blue-50 dark:bg-blue-900/20 text-blue-600 dark:text-blue-400 hover:bg-blue-600 hover:text-white transition-all duration-300 border border-blue-100 dark:border-blue-900/30 active:scale-90 cursor-pointer"
                        >
                            <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" strokeWidth={2} stroke="currentColor" className="w-5 h-5">
                                <path strokeLinecap="round" strokeLinejoin="round" d="M15.75 6a3.75 3.75 0 11-7.5 0 3.75 3.75 0 017.5 0zM4.501 20.118a7.5 7.5 0 0114.998 0A17.933 17.933 0 0112 21.75c-2.676 0-5.216-.584-7.499-1.632z" />
                            </svg>
                        </button>
                    )}
                </div>
            </div>

            <LoginModal isOpen={modalOpen} onClose={() => setModalOpen(false)} />
        </header>    );
}
