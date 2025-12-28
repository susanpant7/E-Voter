import * as React from "react";

type PartyModalProps = {
    open: boolean;
    title: string;
    onClose: () => void;
    children: React.ReactNode;
};

export function PartyModal({ open, title, onClose, children }: PartyModalProps) {
    if (!open) return null;

    return (
        <div className="fixed inset-0 z-50 flex items-center justify-center bg-black/40">
            <div className="w-full max-w-lg rounded bg-white dark:bg-gray-800 shadow-lg">
                {/* Header */}
                <div className="flex items-center justify-between border-b px-4 py-3 dark:border-gray-700">
                    <h2 className="text-lg font-semibold text-gray-900 dark:text-gray-100">
                        {title}
                    </h2>
                    <button
                        onClick={onClose}
                        className="text-gray-500 hover:text-gray-700 dark:hover:text-gray-300"
                    >
                        ✕
                    </button>
                </div>

                {/* Body */}
                <div className="p-4">{children}</div>
            </div>
        </div>
    );
}
