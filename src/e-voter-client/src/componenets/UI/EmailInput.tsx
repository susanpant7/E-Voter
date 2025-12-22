import * as React from "react";
import { isEmpty } from "../../utils/input-validators";

type EmailInputProps = {
    label: string;
    value?: string;
    onChange?: (event: React.ChangeEvent<HTMLInputElement>) => void;
    required?: boolean;
    errorMessage?: string;
    showError?: boolean;
    className?: string;
};

const EMAIL_REGEX = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

export function EmailInput({
                               label,
                               value = "",
                               onChange,
                               required = false,
                               errorMessage,
                               showError = false,
                               className = "",
                           }: EmailInputProps) {
    const [touched, setTouched] = React.useState(false);

    let error: string | undefined;

    if (required && isEmpty(value) && (showError || touched)) {
        error = errorMessage || "Email is required";
    } else if (value && !EMAIL_REGEX.test(value) && (showError || touched)) {
        error = "Please enter a valid email address";
    }

    return (
        <div className={className}>
            <label className="block text-sm font-medium">
                {label} {required && <span className="ml-1 text-red-500">*</span>}
            </label>

            <input
                required={required}
                type="email"
                value={value}
                onChange={onChange}
                onBlur={() => setTouched(true)}
                autoComplete="email"
                className={`mt-1 w-full rounded border px-3 py-2 text-sm
          focus:outline-none focus:ring-2 focus:ring-blue-500
          ${error ? "border-red-500" : "border-gray-300"}`}
            />

            {error && <p className="mt-1 text-sm text-red-500">{error}</p>}
        </div>
    );
}
