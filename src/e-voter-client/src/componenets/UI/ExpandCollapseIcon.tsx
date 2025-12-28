interface ExpandIconProps {
    isExpanded: boolean;
}

export const ExpandCollapseIcon = ({ isExpanded }: ExpandIconProps) => {
    return (
        <div
            className={`flex h-6 w-6 items-center justify-center rounded-md transition-all duration-300 ${
            isExpanded ? 'bg-indigo-100 text-indigo-600 rotate-180' : 'bg-gray-100 text-gray-500 hover:bg-gray-200'
        }`}
>
    <svg
        xmlns="http://www.w3.org/2000/svg"
    fill="none"
    viewBox="0 0 24 24"
    strokeWidth={2.5}
    stroke="currentColor"
    className="h-4 w-4"
    >
    <path strokeLinecap="round" strokeLinejoin="round" d="M19.5 8.25l-7.5 7.5-7.5-7.5" />
        </svg>
        </div>
);
};