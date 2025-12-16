import './App.css'

import {RouterProvider, createRouter, Router} from '@tanstack/react-router';
import {routeTree} from "./app/routeTree.gen.ts";

const router = createRouter({ routeTree });

declare module '@tanstack/react-router' {
    interface Register {
        router: typeof Router;
    }
}
function App() {
    return <RouterProvider router={router} />;
}

export default App;
