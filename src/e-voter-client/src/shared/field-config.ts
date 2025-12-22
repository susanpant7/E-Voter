export type FieldType = "input" | "textarea" | "select" | "checkbox" | "file";

export type FieldConfig = {
    type: FieldType;
    label: string;
    //field: keyof typeof form;
    required?: boolean;
    className?: string;
    options?: { label: string; value: string }[]; // for select
};