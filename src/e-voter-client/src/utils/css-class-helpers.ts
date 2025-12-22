export function getInputClass(error?: string) {
    return `
    mt-1 w-full rounded border px-3 py-2
    bg-white dark:bg-gray-700
    text-gray-900 dark:text-gray-100
    focus:outline-none focus:ring-2
    ${error
        ? "border-red-500 focus:ring-red-500"
        : "border-gray-300 dark:border-gray-600 focus:ring-blue-500"
    }
  `;
}
