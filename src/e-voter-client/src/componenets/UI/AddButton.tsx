type AddButtonProps = {
    onClick: () => void;
    label: string;
};

export const AddButton = ({ onClick, label }: AddButtonProps) => {
    return (
        <button
            type="button"
            onClick={onClick}
            className="
                group inline-flex items-center gap-2
                rounded-md
                bg-linear-to-r from-indigo-600 to-indigo-500
                px-4 py-2        /* increased height */
                text-sm font-semibold text-white
                shadow-sm
                transition-all duration-200 ease-out
                hover:from-indigo-700 hover:to-indigo-600
                hover:shadow-md hover:-translate-y-0.5
                active:translate-y-0 active:shadow-sm
                focus:outline-none focus-visible:ring-2 focus-visible:ring-indigo-500 focus-visible:ring-offset-2
                cursor-pointer   /* show pointer */
            "
        >
            <span
                className="
                    inline-flex h-5 w-5 items-center justify-center
                    rounded-full bg-white/20
                    text-sm font-bold leading-none
                    transition-transform duration-200
                    group-hover:rotate-90 group-hover:scale-110
                "
            >
                +
            </span>

            <span className="whitespace-nowrap">
                {label}
            </span>
        </button>
    );
};
