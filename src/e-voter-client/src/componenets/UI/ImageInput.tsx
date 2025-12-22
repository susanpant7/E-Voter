import * as React from "react";

type ImageInputProps = {
    label: string;
    value?: File | null;
    onChange: (file: File) => void; // always a File
    imageUrl?: string | null;        // existing image URL
    imageName?: string | null;       // name of the image to display
    maxSizeMB?: number;
    acceptedFormats?: string[];
    className?: string;
};

export function ImageInput({
                               label,
                               value,
                               onChange,
                               imageUrl = null,
                               imageName = null,
                               maxSizeMB = 2,
                               acceptedFormats = ["image/png", "image/jpeg", "image/webp", "image/svg"],
                               className = "",
                           }: ImageInputProps) {
    const [preview, setPreview] = React.useState<string | null>(imageUrl);
    const [error, setError] = React.useState<string | null>(null);
    const [selectedFileName, setSelectedFileName] = React.useState<string | null>(imageName);

    React.useEffect(() => {
        if (value) {
            const reader = new FileReader();
            reader.onload = () => setPreview(reader.result as string);
            reader.readAsDataURL(value);
            setSelectedFileName(value.name); // show selected file name
        } else {
            setPreview(imageUrl ?? null);
            setSelectedFileName(imageName ?? null); // fallback to passed imageName
        }
    }, [value, imageUrl, imageName]);

    const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        const file = e.target.files?.[0];
        if (!file) {
            setPreview(imageUrl ?? null);
            setSelectedFileName(imageName ?? null);
            return;
        }

        if (!acceptedFormats.includes(file.type)) {
            setError("Unsupported image format");
            return;
        }

        if (file.size > maxSizeMB * 1024 * 1024) {
            setError(`Image must be smaller than ${maxSizeMB}MB`);
            return;
        }

        setError(null);
        setPreview(URL.createObjectURL(file));
        setSelectedFileName(file.name);
        onChange(file);
    };

    return (
        <div className={`flex flex-col gap-2 ${className}`}>
            <label className="block text-sm font-medium">{label}</label>

            {/* Hidden file input */}
            <input
                type="file"
                accept={acceptedFormats.join(",")}
                onChange={handleChange}
                className="hidden"
                id={`file-upload-${label}`}
            />

            {/* Custom button and filename display */}
            <label
                htmlFor={`file-upload-${label}`}
                className="flex items-center justify-between cursor-pointer mt-1 px-4 py-2 bg-blue-50 text-blue-700 rounded hover:bg-blue-100 text-sm font-medium"
            >
                <span>{selectedFileName ?? "Choose file"}</span>
                <span className="ml-2 text-gray-500">Browse</span>
            </label>

            <p className="text-xs text-gray-500">
                Accepted: {acceptedFormats.map(f => f.split("/")[1]).join(", ")} · Max {maxSizeMB}MB
            </p>

            {error && <p className="text-sm text-red-500">{error}</p>}

            {preview ? (
                <img
                    src={preview}
                    alt="Preview"
                    className="mt-2 max-w-xs w-full rounded-xl shadow-lg border border-gray-200"
                />
            ) : (
                <div className="mt-2 flex justify-center items-center w-full p-6 border-2 border-dashed border-gray-300 rounded-xl text-gray-400">
                    <p className="text-sm">No image selected yet</p>
                </div>
            )}
        </div>
    );
}
