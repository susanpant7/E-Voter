import * as React from "react";

type RadioInputProps = {
    label: string;
    name: string;
    options: string[];
    value?: string;
    onChange?: (event: React.ChangeEvent<HTMLInputElement>) => void;
    className?: string;
};

export function RadioInput({
                               label,
                               name,
                               options,
                               value,
                               onChange,
                               className = "",
                           }: RadioInputProps) {
    return (
        <div className={className}>
            <p className="mb-1 text-sm font-medium">{label}</p>
            <div className="space-y-1">
                {options.map((opt) => (
                    <label key={opt} className="flex items-center gap-2 text-sm">
                        <input
                            type="radio"
                            name={name}
                            value={opt}
                            checked={value === opt}
                            onChange={onChange}
                        />
                        {opt}
                    </label>
                ))}
            </div>
        </div>
    );
}
