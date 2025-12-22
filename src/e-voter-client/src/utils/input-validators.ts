export function isRequired(value?: string) {
    return !value || value.trim() === "" ? "This field is required" : undefined;
}

export function isEmail(value?: string) {
    if (!value) return;
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(value) ? undefined : "Invalid email address";
}

export function isNumber(value?: string) {
    if (!value) return;
    return isNaN(Number(value)) ? "Must be a number" : undefined;
}

export function minLength(value?: string, length = 6) {
    if (!value) return;
    return value.length < length
        ? `Must be at least ${length} characters`
        : undefined;
}

export function isEmpty(value?: string) {
    return !value || value.trim() === "";
}
    