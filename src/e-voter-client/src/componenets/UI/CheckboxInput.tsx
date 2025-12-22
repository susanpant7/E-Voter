import * as React from "react";

type CheckboxInputProps = {
    label: string;
    checked?: boolean;
    onChange?: (event: React.ChangeEvent<HTMLInputElement>) => void;
    className?: string;
};

export function CheckboxInput({
                                  label,
                                  checked = false,
                                  onChange,
                                  className = "",
                              }: CheckboxInputProps) {
    return (
        <div className={`flex items-center gap-2 ${className}`}>
            <input
                type="checkbox"
                checked={checked}
                onChange={onChange}
                className="h-4 w-4 rounded border-gray-300"
            />
            <label className="text-sm">{label}</label>
        </div>
    );
}
