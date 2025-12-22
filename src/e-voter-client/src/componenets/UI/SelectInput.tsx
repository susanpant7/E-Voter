import * as React from "react";
import {isEmpty} from "../../utils/input-validators.ts";

type SelectOption = {
    label: string;
    value: string;
};

type SelectProps = {
    label: string;
    value?: string;
    options: SelectOption[];
    onChange?: (event: React.ChangeEvent<HTMLSelectElement>) => void;
    required?: boolean;
    errorMessage?: string;
    showError?: boolean;
    className?: string;
};

export function SelectInput({
                                label,
                                value = "",
                                options,
                                onChange,
                                required = false,
                                errorMessage,
                                showError = false,
                                className = "",
                       }: SelectProps) {

    const [touched, setTouched] = React.useState(false);

    const error =
        required && isEmpty(value) && (showError || touched)
            ? errorMessage || "This field is required"
            : undefined;

    return (
        <div className={className}>
            <label className="block text-sm font-medium">
                {label} {required && <span className="text-red-500">*</span>}
            </label>

            <select
                required={required}
                value={value}
                onChange={onChange}
                onBlur={() => setTouched(true)}
                className={`mt-1 w-full rounded border px-3 py-2
          ${error ? "border-red-500" : "border-gray-300"}`}
            >
                <option value="">Select...</option>
                {options.map(option => (
                    <option key={option.value} value={option.value}>
                        {option.label}
                    </option>
                ))}
            </select>

            {error && <p className="mt-1 text-sm text-red-500">{error}</p>}
        </div>
    );
}
