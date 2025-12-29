import * as React from 'react'
import {Outlet, createRootRoute} from '@tanstack/react-router'
import {NotificationBar} from "../../componenets/UI/Toast.tsx";
import Header from "./-navbar/Header.tsx";

export const Route = createRootRoute({
    component: RootComponent,
});

function RootComponent() {
  return (
      <>
          <NotificationBar />
          <React.Fragment>
              <div className="min-h-screen flex flex-col bg-gray-50 dark:bg-gray-900">
                  <Header />
                  <main className="flex-1">
                      <Outlet />
                  </main>
              </div>
          </React.Fragment>
      </>
  )
}