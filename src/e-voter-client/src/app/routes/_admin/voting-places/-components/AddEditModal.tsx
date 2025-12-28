import * as React from "react";

interface GenericModalProps {
    isOpen: boolean;
    title: string;
    onClose: () => void;
    onSave?: () => void;
    children: React.ReactNode;
}

export function AddEditModal({
                                 isOpen,
                                 title,
                                 onClose,
                                 onSave,
                                 children,
                             }: GenericModalProps) {
    if (!isOpen) return null;

    return (
        <div className="fixed inset-0 z-50 flex items-center justify-center bg-black/40">
            <div className="w-full max-w-lg rounded-xl bg-white p-6 shadow-xl">
                {/* Header */}
                <div className="mb-4 flex items-center justify-between">
                    <h2 className="text-xl font-semibold text-gray-800">
                        {title}
                    </h2>

                    <button
                        onClick={onClose}
                        className="text-gray-500 hover:text-gray-700"
                    >
                        ✕
                    </button>
                </div>

                {/* Body */}
                <div className="mb-6">
                    {children}
                </div>

                {/* Footer */}
                <div className="flex justify-end gap-2">
                    <button
                        onClick={onClose}
                        className="rounded-md border px-4 py-2 text-sm text-gray-700 hover:bg-gray-100"
                    >
                        Cancel
                    </button>

                    {onSave && (
                        <button
                            onClick={onSave}
                            className="rounded-md bg-blue-600 px-4 py-2 text-sm text-white hover:bg-blue-700"
                        >
                            Save
                        </button>
                    )}
                </div>
            </div>
        </div>
    );
}
