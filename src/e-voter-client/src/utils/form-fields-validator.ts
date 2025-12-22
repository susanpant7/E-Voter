import * as React from "react";

/**
 * Validate required fields in a form.
 *
 * @param formEvent - the submit event
 * @returns true if all required fields are filled, false otherwise
 */
export function validateRequiredFields(
    formEvent: React.FormEvent<HTMLFormElement>
): boolean {
    const form = formEvent.currentTarget;
    // Get all inputs, textareas, selects
    const requiredFields = Array.from(
        form.querySelectorAll<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>(
            "[required]"
        )
    );

    // Find the first field that is empty
    const firstInvalid = requiredFields.find((field) => {
        if (field.type === "checkbox" || field.type === "radio") {
            return !(field as HTMLInputElement).checked;
        }
        return !field.value || field.value.trim() === "";
    });

    if (firstInvalid) {
        // Scroll into view and focus
        firstInvalid.scrollIntoView({ behavior: "smooth", block: "center" });
        firstInvalid.focus({ preventScroll: true });
        return false;
    }

    return true;
}
