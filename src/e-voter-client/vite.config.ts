import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import tailwindcss from "@tailwindcss/vite";
import {tanstackRouter} from "@tanstack/router-plugin/vite";

// https://vite.dev/config/
export default defineConfig({
    plugins: [
    tailwindcss(),
    tanstackRouter(
        {
          target: "react",
          autoCodeSplitting: true,
          routesDirectory: './src/app/routes',
          generatedRouteTree: './src/app/routeTree.gen.ts',
        }
    ),
    react({
      babel: {
        plugins: [['babel-plugin-react-compiler']],
      },
    }), 
  ],
    resolve: {
        dedupe: ['react', 'react-dom'],
    },
})
