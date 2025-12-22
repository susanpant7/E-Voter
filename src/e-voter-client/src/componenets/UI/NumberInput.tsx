import * as React from "react";
import { isEmpty } from "../../utils/input-validators";

type NumberInputProps = {
    label: string;
    value?: string;
    onChange?: (value: string) => void;
    required?: boolean;
    errorMessage?: string;
    showError?: boolean;
    className?: string;
    placeholder?: string;
};

export function NumberInput({
                                label,
                                value = "",
                                onChange,
                                required = false,
                                errorMessage,
                                showError = false,
                                className = "",
                                placeholder,
                            }: NumberInputProps) {
    const [touched, setTouched] = React.useState(false);

    const error =
        required && isEmpty(value) && (showError || touched)
            ? errorMessage || "This field is required"
            : undefined;

    const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        // allow digits only
        const digitsOnly = e.target.value.replace(/\D/g, "");
        onChange?.(digitsOnly);
    };

    return (
        <div className={className}>
            <label className="block text-sm font-medium">
                {label} {required && <span className="text-red-500">*</span>}
            </label>

            <input
                required={required}
                type="text"
                inputMode="numeric"
                pattern="[0-9]*"
                value={value}
                placeholder={placeholder}
                onChange={handleChange}
                onBlur={() => setTouched(true)}
                className={`mt-1 w-full rounded border px-3 py-2 text-sm
          focus:outline-none focus:ring-2 focus:ring-blue-500
          ${error ? "border-red-500" : "border-gray-300"}
          appearance-none`}
            />

            {error && <p className="mt-1 text-sm text-red-500">{error}</p>}
        </div>
    );
}
