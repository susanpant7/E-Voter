import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import {loadCurrentUser} from "./api/auth/auth.ts";
import {QueryClient, QueryClientProvider} from "@tanstack/react-query";

async function bootstrap() {
    await loadCurrentUser()
}

const queryClient = new QueryClient({
    defaultOptions: {
        queries: {
            // This disables retries for all useQuery hooks in your app
            retry: false,

            // Optional: You might also want to disable refetching 
            // when you switch browser tabs during debugging
            refetchOnWindowFocus: false,
        },
    },
});

bootstrap().then(() => {
    createRoot(document.getElementById('root')!).render(
        <StrictMode>
            <QueryClientProvider client={queryClient}>
                <App/>    
            </QueryClientProvider>
        </StrictMode>,
    )
})
