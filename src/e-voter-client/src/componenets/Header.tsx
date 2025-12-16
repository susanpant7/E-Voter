import { Link } from "@tanstack/react-router";
import { useState, useEffect } from "react";
import LoginModal from "./auth/LoginModal.tsx";
import {logoutApi} from "../api/auth/auth.ts";
import {getUserNavbarLinks} from "../utils/NavbarLinks.ts";
import {getToken} from "../auth/authProvider.ts";

export default function Header() {
    const [isLoggedIn, setIsLoggedIn] = useState(false);
    const [userNavLinks, setUserNavLinks] = useState([]);
    
    const [modalOpen, setModalOpen] = useState(false);

    // Dark mode
    const [darkMode, setDarkMode] = useState(false);

    useEffect(() => {
        const storedTheme = localStorage.getItem("theme");
        if (storedTheme === "dark") {
            setDarkMode(true);
            document.documentElement.classList.add("dark");
        }

        getToken().then(token => {
            setIsLoggedIn(!!token);
            setUserNavLinks(getUserNavbarLinks(token));
        });
        
    }, []);

    const toggleTheme = () => {
        setDarkMode((prev) => {
            const newTheme = !prev;
            if (newTheme) {
                document.documentElement.classList.add("dark");
                localStorage.setItem("theme", "dark");
            } else {
                document.documentElement.classList.remove("dark");
                localStorage.setItem("theme", "light");
            }
            return newTheme;
        });
    };

    return (
        <header className="py-4 shadow-md bg-white dark:bg-gray-900 transition-colors duration-300">
            <div className="max-w-6xl mx-auto px-4 flex justify-between items-center">
                <Link
                    to="/"
                    className="text-2xl font-bold text-blue-700 dark:text-blue-300 hover:text-blue-600 dark:hover:text-blue-400 transition-colors"
                >
                    E-Voter Nepal
                </Link>

                <nav className="flex items-center gap-6">
                    {/* Links */}
                    {userNavLinks.map((link) => (
                        <Link
                            key={link.path}
                            to={link.path}
                            className="text-gray-800 dark:text-gray-200 hover:text-blue-600 dark:hover:text-blue-400 transition-colors font-medium"
                        >
                            {link.name}
                        </Link>
                    ))}

                    {/* Dark/Light toggle */}
                    <button
                        onClick={toggleTheme}
                        className="p-2 rounded-full bg-gray-200 dark:bg-gray-700 hover:bg-gray-300 dark:hover:bg-gray-600 transition-colors"
                        title={darkMode ? "Switch to Light Mode" : "Switch to Dark Mode"}
                    >
                        {darkMode ? "☀️" : "🌙"}
                    </button>

                    {/* Auth buttons */}
                    {!isLoggedIn ? (
                        <LoginButton onLogin={() => setModalOpen(true)} />
                    ) : (
                        <LogoutButton onLogout={logoutApi} />
                    )}
                </nav>
            </div>
            <LoginModal isOpen={modalOpen} onClose={() => setModalOpen(false)} />
        </header>
    );
}

function LoginButton({ onLogin }: { onLogin: () => void }) {
    return (
        <button
            onClick={onLogin}
            className="px-4 py-2 bg-blue-600 text-white rounded-lg hover:bg-blue-700 shadow-md transition-colors"
        >
            Login
        </button>
    );
}

function LogoutButton({ onLogout }: { onLogout: () => void }) {
    return (
        <button
            onClick={onLogout}
            className="px-4 py-2 bg-red-600 text-white rounded-lg hover:bg-red-700 shadow-md transition-colors"
        >
            Logout
        </button>
    );
}
