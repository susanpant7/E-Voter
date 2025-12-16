export default function  StatusField({ label, value }: { label: string; value: boolean }) {
    return (
        <div className="bg-gray-50 dark:bg-gray-700 rounded-lg p-4 shadow-sm">
            <div className="text-sm text-gray-500 dark:text-gray-300">{label}</div>
            <div
                className={`mt-1 font-semibold ${
                    value ? 'text-green-600 dark:text-green-400' : 'text-red-600 dark:text-red-400'
                }`}
            >
                {value ? 'Yes' : 'No'}
            </div>
        </div>
    );
}