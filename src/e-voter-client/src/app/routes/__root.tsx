import * as React from 'react'
import {Outlet, createRootRoute} from '@tanstack/react-router'
import Header from "../../componenets/Header.tsx";

export const Route = createRootRoute({
    component: RootComponent, 
});

function RootComponent() {
  return (
    <React.Fragment>
        <div className="min-h-screen flex flex-col bg-gray-50 dark:bg-gray-900">
            <Header />
            <main className="flex-1">
                <Outlet />
            </main>
        </div>
    </React.Fragment>
  )
}
