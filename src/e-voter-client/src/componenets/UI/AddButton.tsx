export const AddButton = ({ onClick }: { onClick: () => void }) => (
    <button
        onClick={onClick}
        className="flex items-center gap-2 rounded bg-indigo-600 px-3 py-1.5 text-xs font-semibold text-white hover:bg-indigo-700 transition-colors"
    >
        <span className="text-lg leading-none">+</span>
    </button>
);