import * as React from "react";
import { isEmpty } from "../../utils/input-validators";

type PasswordInputProps = {
    label: string;
    value?: string;
    onChange?: (event: React.ChangeEvent<HTMLInputElement>) => void;
    required?: boolean;
    errorMessage?: string;
    showError?: boolean;
    className?: string;
};

export function PasswordInput({
                                  label,
                                  value = "",
                                  onChange,
                                  required = false,
                                  errorMessage,
                                  showError = false,
                                  className = "",
                              }: PasswordInputProps) {
    const [touched, setTouched] = React.useState(false);
    const [visible, setVisible] = React.useState(false);

    // Show error if required and empty
    const error =
        required && isEmpty(value) && (showError || touched)
            ? errorMessage || "This field is required"
            : undefined;

    return (
        <div className={className}>
            <label className="block text-sm font-medium">
                {label} {required && <span className="text-red-500">*</span>}
            </label>

            <div className="relative mt-1">
                {/* Pass required to the actual input */}
                <input
                    type={visible ? "text" : "password"}
                    value={value}
                    onChange={onChange}
                    onBlur={() => setTouched(true)}
                    required={required} 
                    className={`w-full rounded border px-3 py-2 pr-10 text-sm
                    focus:outline-none focus:ring-2 focus:ring-blue-500
                    ${error ? "border-red-500" : "border-gray-300"}`}
                />

                {/* Toggle visibility button */}
                <button
                    type="button"
                    onClick={() => setVisible((v) => !v)}
                    className="absolute inset-y-0 right-2 flex items-center text-gray-500 hover:text-gray-700"
                    tabIndex={-1}
                >
                    {visible ? "🙈" : "👁️"}
                </button>
            </div>

            {/* Error message */}
            {error && <p className="mt-1 text-sm text-red-500">{error}</p>}
        </div>
    );
}
