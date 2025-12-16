import { createFileRoute } from '@tanstack/react-router'

export const Route = createFileRoute('/_admin/election-parties/')({
  component: RouteComponent,
})

function RouteComponent() {
  return <div>Hello "/_admin/election-parties/"!</div>
}
