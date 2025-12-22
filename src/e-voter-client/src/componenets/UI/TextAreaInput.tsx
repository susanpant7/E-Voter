import * as React from "react";
import { isEmpty } from "../../utils/input-validators";

type TextareaInputProps = {
    label: string;
    value?: string;
    onChange?: (event: React.ChangeEvent<HTMLTextAreaElement>) => void;
    required?: boolean;
    errorMessage?: string;
    showError?: boolean;
    className?: string;
    rows?: number;
};

export function TextareaInput({
                                  label,
                                  value = "",
                                  onChange,
                                  required = false,
                                  errorMessage,
                                  showError = false,
                                  className = "",
                                  rows = 4,
                              }: TextareaInputProps) {
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

            <textarea
                required={required}
                rows={rows}
                value={value}
                onChange={onChange}
                onBlur={() => setTouched(true)}
                className={`mt-1 w-full rounded border px-3 py-2
          ${error ? "border-red-500" : "border-gray-300"}`}
            />

            {error && <p className="mt-1 text-sm text-red-500">{error}</p>}
        </div>
    );
}
