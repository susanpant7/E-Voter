// src/ui/toast.tsx
import toast, {ToastBar, Toaster} from 'react-hot-toast'
import type {Toast} from 'react-hot-toast'

export function NotificationBar(){
    return (
        <Toaster
            position="top-right"
            reverseOrder={true}
            toastOptions={{
                duration: 3000,
            }}
        >
            {(t:Toast) => {
                return (
                    <div
                        className="w-auto cursor-pointer"
                        onClick={() => toast.dismiss(t.id)}
                    >
                        <ToastBar toast={t} />
                    </div>
                );
            }}
        </Toaster>
    );
}
export function showErrorNotification(message: string) {
    toast.error(message, {
        duration: Infinity,
        style: {
            background: '#dc2626', // Tailwind red-600
            color: '#ffffff',
        },
        className: `
            rounded-xl
            shadow-lg
            px-4 py-3
            font-medium
            `,
        iconTheme: {
            primary: '#ffffff',
            secondary: '#dc2626',
        },
    });
}

export function showSuccessNotification(message: string) {
    toast.success(message, {
        style: {
            background: '#059669',
            color: '#ffffff',
        },
        className: `
            rounded-xl
            shadow-lg
            px-4 py-3
            font-medium
            `,
        iconTheme: {
            primary: '#ffffff',
            secondary: '#059669',
        },
    });
}
