import React from "react";

interface ActionButtonProps {
    onClick: () => void;
    provinceName?: string;
}

export const DeleteButton: React.FC<ActionButtonProps> = ({ onClick, provinceName }) => {
    return (
        <button
            onClick={onClick}
    className="group relative px-4 py-2.5 bg-linear-to-r from-red-50 to-red-100 border border-red-200 rounded-lg hover:from-red-100 hover:to-red-200 transition-all duration-200 hover:shadow-md cursor-pointer"
    title={`Delete ${provinceName || 'province'}`}
>
    <div className="flex items-center space-x-2">
    <svg
        className="w-4 h-4 text-red-600 group-hover:scale-110 transition-transform duration-200"
    fill="none"
    stroke="currentColor"
    viewBox="0 0 24 24"
    xmlns="http://www.w3.org/2000/svg"
    >
    <path
        strokeLinecap="round"
    strokeLinejoin="round"
    strokeWidth="2"
    d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6m1-10V4a1 1 0 00-1-1h-4a1 1 0 00-1 1v3M4 7h16"
        ></path>
        </svg>
        </div>
        <div className="absolute -bottom-1 left-0 w-0 group-hover:w-full h-0.5 bg-linear-to-r from-red-500 to-red-600 transition-all duration-200 rounded-full"></div>
        </button>
);
};