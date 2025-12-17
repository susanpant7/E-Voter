import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import {loadCurrentUser} from "./api/auth/auth.ts";

async function bootstrap() {
    await loadCurrentUser()
}

bootstrap().then(() => {
    createRoot(document.getElementById('root')!).render(
        <StrictMode>
            <App/>
        </StrictMode>,
    )
})
