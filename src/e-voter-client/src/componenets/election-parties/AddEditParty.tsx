import * as React from "react";
import { useState, useEffect } from "react";
import { TextInput } from "../UI/TextInput.tsx";
import { TextareaInput } from "../UI/TextAreaInput.tsx";
import { CheckboxInput } from "../UI/CheckboxInput.tsx";
import { EmailInput } from "../UI/EmailInput.tsx";
import { type ElectionPartyDetail, PartyStatus } from "../../api/election-parties/election-party.types.ts";
import { validateRequiredFields } from "../../utils/form-fields-validator.ts";
import { useMutation } from "@tanstack/react-query";
import { upsertMediaFileMutationOptions } from "../../api/media-files/media-files-query-options.ts";
import { ImageInput } from "../UI/ImageInput.tsx";
import { Link } from "@tanstack/react-router";

type ElectionPartyFormProps = {
    initialData?: Partial<ElectionPartyDetail>;
    onSubmit?: (data: ElectionPartyDetail) => Promise<void> | void;
};

const EMPTY_FORM: ElectionPartyDetail = {
    id: 0,
    name: "",
    abbreviation: "",
    description: "",
    leaderName: "",
    founderName: "",
    foundedOn: new Date().toISOString().slice(0, 10),
    isRecognizedNationally: false,
    status: PartyStatus.Active,
    ideology: "",
    politicalSpectrum: "",
    officialWebsite: "",
    contactEmail: "",
    contactPhone: "",
    headquartersAddress: "",
    logoFileId: null,
};

export function ElectionPartyForm({ initialData, onSubmit }: ElectionPartyFormProps) {
    const imageUpsertMutation = useMutation(upsertMediaFileMutationOptions());
    const isEditMode = !!initialData;
    const [initialPartyName, setInitialPartyName] = useState<string | undefined>(undefined);

    const [partyDetail, setPartyDetail] = useState<ElectionPartyDetail>(EMPTY_FORM);
    const [saving, setSaving] = useState(false);
    const [imgLogoUrl, setImgLogoUrl] = useState<string | null>(null);
    const [imgLogoName, setImgLogoName] = useState<string | null>(null);

    useEffect(() => {
        if (initialData) {
            setPartyDetail((prev) => ({ ...prev, ...initialData }));
            setInitialPartyName(initialData.name);
            if (initialData.logoFileId) {
                setImgLogoUrl(`http://localhost:5244/api/media-files/${initialData.logoFileId}?t=${Date.now()}`);
            }
            setImgLogoName(initialData.logoFileName ?? null);
        }
    }, [initialData]);

    const updateField =
        (key: keyof ElectionPartyDetail) =>
            (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>) => {
                const value =
                    e.target.type === "checkbox"
                        ? (e.target as HTMLInputElement).checked
                        : e.target.value;
                setPartyDetail((prev) => ({ ...prev, [key]: value }));
            };

    const handleLogoChange = async (file: File) => {
        setSaving(true);
        const imgFormData = new FormData();
        imgFormData.append("file", file);

        const logoId = await imageUpsertMutation.mutateAsync({
            formData: imgFormData,
            id: partyDetail.logoFileId ?? 0,
        });

        setImgLogoUrl(`http://localhost:5244/api/media-files/${logoId}?t=${Date.now()}`);
        setImgLogoName(file.name);
        setPartyDetail((prev) => ({ ...prev, logoFileId: logoId }));
        setSaving(false);
    };

    const submit = async (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        if (!validateRequiredFields(e)) return;

        setSaving(true);
        await onSubmit?.(partyDetail);
        setSaving(false);
    };

    return (
        <div className="flex flex-col min-h-screen bg-gray-50 dark:bg-gray-900 text-gray-900 dark:text-gray-100 px-4 py-6">
            <form
                onSubmit={submit}
                className="w-full mx-auto bg-white dark:bg-gray-800 rounded-lg shadow-lg p-6"
            >
                <FormHeader partyName={initialPartyName} />

                <FormSection title="Basic Information">
                    <TextInput label="Party Name" value={partyDetail.name} onChange={updateField("name")} required />
                    <TextInput label="Abbreviation" value={partyDetail.abbreviation} onChange={updateField("abbreviation")} required />
                    <TextareaInput label="Description" value={partyDetail.description} onChange={updateField("description")} className="md:col-span-2" />
                    <TextInput label="Ideology" value={partyDetail.ideology} onChange={updateField("ideology")} />
                    <TextInput label="Political Spectrum" value={partyDetail.politicalSpectrum} onChange={updateField("politicalSpectrum")} />
                </FormSection>

                <FormSection title="Leadership">
                    <TextInput label="Leader Name" value={partyDetail.leaderName} onChange={updateField("leaderName")} />
                    <TextInput label="Founder Name" value={partyDetail.founderName} onChange={updateField("founderName")} />
                </FormSection>

                <FormSection title="Registration & Status">
                    <TextInput label="Founded On" type="date" value={partyDetail.foundedOn} onChange={updateField("foundedOn")} required />
                    <CheckboxInput label="Recognized Nationally" checked={partyDetail.isRecognizedNationally} onChange={updateField("isRecognizedNationally")} />
                    <div className="md:col-span-2">
                        <label className="block mb-1 font-medium text-gray-700 dark:text-gray-200">Status</label>
                        <select
                            value={partyDetail.status}
                            onChange={updateField("status")}
                            className="w-full rounded border px-3 py-2 dark:bg-gray-700 dark:text-gray-100"
                        >
                            <option value={PartyStatus.Active}>Active</option>
                            <option value={PartyStatus.Inactive}>Inactive</option>
                            <option value={PartyStatus.Suspended}>Suspended</option>
                        </select>
                    </div>
                </FormSection>

                <FormSection title="Contact & Headquarters">
                    <TextInput label="Official Website" value={partyDetail.officialWebsite} onChange={updateField("officialWebsite")} />
                    <EmailInput label="Contact Email" value={partyDetail.contactEmail} onChange={updateField("contactEmail")} />
                    <TextInput label="Contact Phone" value={partyDetail.contactPhone} onChange={updateField("contactPhone")} />
                    <TextareaInput label="Headquarters Address" value={partyDetail.headquartersAddress} onChange={updateField("headquartersAddress")} className="md:col-span-2" />
                </FormSection>

                <FormSection title="Party Logo">
                    <ImageInput label="Party Logo" imageUrl={imgLogoUrl} imageName={imgLogoName} onChange={handleLogoChange} />
                </FormSection>

                {/* Buttons at the end of form, right-aligned */}
                <FormActions isEdit={isEditMode} saving={saving} />
            </form>
        </div>
    );
}

// Header
const FormHeader = ({ partyName }: { partyName?: string }) => (
    <div className="flex items-center justify-between mb-4">
        <h1 className="text-2xl font-semibold text-gray-800 dark:text-gray-100">
            {partyName ?  partyName : "Add Election Party" }
        </h1>
    </div>
);

// Section wrapper
const FormSection = ({ title, children }: { title: string; children: React.ReactNode }) => (
    <section className="rounded-lg border bg-white dark:bg-gray-700 p-6 shadow-sm mb-6">
        <h2 className="mb-4 text-lg font-medium text-gray-700 dark:text-gray-200">{title}</h2>
        <div className="grid grid-cols-1 gap-4 md:grid-cols-2 lg:grid-cols-3">{children}</div>
    </section>
);

// Form actions (buttons)
const FormActions = ({ isEdit, saving }: { isEdit: boolean; saving: boolean }) => (
    <div className="flex justify-end gap-3 mt-6">
        <Link
            to="/election-parties"
            className="rounded border px-4 py-2 text-sm bg-white dark:bg-gray-700 text-gray-800 dark:text-gray-200 hover:bg-gray-100 dark:hover:bg-gray-600 transition"
        >
            Cancel
        </Link>

        <button
            type="submit"
            disabled={saving}
            className="rounded bg-blue-600 px-6 py-2 text-sm text-white hover:bg-blue-700 disabled:opacity-50 cursor-pointer transition"
        >
            {saving ? "Saving..." : isEdit ? "Update Party" : "Create Party"}
        </button>
    </div>
);
