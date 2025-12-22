import * as React from "react";
import {isEmpty} from "../../utils/input-validators.ts";

type TextInputProps = {
    label: string;
    value?: string;
    onChange?: (event: React.ChangeEvent<HTMLInputElement>) => void;
    required?: boolean;
    errorMessage?: string;
    showError?: boolean;
    className?: string;
    type?: string;
};

export function TextInput({
                              label,
                              value = "",
                              onChange,
                              required = false,
                              errorMessage,
                              showError = false,
                              className = "",
                          }: TextInputProps) {
    const [touched, setTouched] = React.useState(false);

    const error =
        (required && isEmpty(value) && (showError || touched))
            ? errorMessage || "This field is required"
            : undefined;

    const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        if(onChange)
            onChange(e);
    };

    const handleBlur = () => {
        setTouched(true);
    };

    return (
        <div className={className}>
            <label className="block text-sm font-medium">
                {label} {required && <span className="ml-1 text-red-500">*</span>}
            </label>
            <input
                required={required}
                type="text"
                value={value}
                onChange={handleChange}
                onBlur={handleBlur}
                className={`mt-1 w-full rounded border px-3 py-2
          ${error ? "border-red-500" : "border-gray-300"}`}
            />
            {error && <p className="mt-1 text-sm text-red-500">{error}</p>}
        </div>
    );
}
