import React from 'react';

interface ActionButtonProps {
    onClick: () => void;
    provinceName?: string;
}

export const EditButton: React.FC<ActionButtonProps> = ({ onClick, provinceName }) => {
    return (
        <button
            onClick={onClick}
            className="group relative px-4 py-2.5 bg-linear-to-r from-blue-50 to-blue-100 border border-blue-200 rounded-lg hover:from-blue-100 hover:to-blue-200 transition-all duration-200 hover:shadow-md cursor-pointer"
            title={`Edit ${provinceName || 'province'}`}
        >
            <div className="flex items-center space-x-2">
                <svg
                    className="w-4 h-4 text-blue-600 group-hover:scale-110 transition-transform duration-200"
                    fill="none"
                    stroke="currentColor"
                    viewBox="0 0 24 24"
                    xmlns="http://www.w3.org/2000/svg"
                >
                    <path
                        strokeLinecap="round"
                        strokeLinejoin="round"
                        strokeWidth="2"
                        d="M11 5H6a2 2 0 00-2 2v11a2 2 0 002 2h11a2 2 0 002-2v-5m-1.414-9.414a2 2 0 112.828 2.828L11.828 15H9v-2.828l8.586-8.586z"
                    ></path>
                </svg>
                
            </div>
            <div className="absolute -bottom-1 left-0 w-0 group-hover:w-full h-0.5 bg-linear-to-r from-blue-500 to-blue-600 transition-all duration-200 rounded-full"></div>
        </button>
    );
};