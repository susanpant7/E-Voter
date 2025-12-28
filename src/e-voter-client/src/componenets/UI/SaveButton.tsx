export const SaveButton = ({ onClick }: { onClick: () => void }) => (
    <button
        onClick={onClick}
className="rounded bg-green-100 p-2 text-green-700 hover:bg-green-200 transition-colors"
title="Save"
>
<svg xmlns="http://www.w3.org/2000/svg" className="h-4 w-4" fill="none" viewBox="0 0 24 24" stroke="currentColor">
<path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M5 13l4 4L19 7" />
    </svg>
    </button>
);