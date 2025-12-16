export default function  Field({ label, value }: { label: string; value: string | number }) {
    return (
        <div className="bg-gray-50 dark:bg-gray-700 rounded-lg p-4 shadow-sm">
            <div className="text-sm text-gray-500 dark:text-gray-300">{label}</div>
            <div className="text-gray-900 dark:text-white font-medium mt-1">
                {value}
            </div>
        </div>
    );
}