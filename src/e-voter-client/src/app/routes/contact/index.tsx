import { createFileRoute } from '@tanstack/react-router'

export const Route = createFileRoute('/contact/')({
  component: RouteComponent,
})

function RouteComponent() {
  return <ContactUsPage />
}

function ContactUsPage() {
    return (
        <div className="min-h-screen bg-gray-50 dark:bg-gray-900 text-gray-900 dark:text-gray-100 flex flex-col">
            <div className="max-w-3xl mx-auto px-4 py-12">
                <h1 className="text-3xl font-bold mb-6">Contact Us</h1>

                <section className="mb-8 space-y-4">
                    <h2 className="text-2xl font-semibold">Election Commission, Nepal (ECN)</h2>
                    <p><strong>Address:</strong> Kantipath, Kathmandu, Nepal</p>
                    <p><strong>Phone:</strong> +977‑01‑5328663</p>
                    <p><strong>Email:</strong> <a href="mailto:info@election.gov.np" className="text-blue-600 dark:text-blue-400 hover:underline">info@election.gov.np</a></p>
                    <p><strong>Official Website:</strong> <a href="https://election.gov.np" className="text-blue-600 dark:text-blue-400 hover:underline">election.gov.np</a></p>
                </section>

                <section className="mb-8">
                    <h2 className="text-2xl font-semibold mb-4">Get in Touch</h2>
                    <form className="space-y-4">
                        <div>
                            <label className="block mb-1">Your Name</label>
                            <input type="text" className="w-full px-4 py-2 border rounded-md bg-white dark:bg-gray-800 dark:border-gray-700" placeholder="Name" />
                        </div>

                        <div>
                            <label className="block mb-1">Your Email</label>
                            <input type="email" className="w-full px-4 py-2 border rounded-md bg-white dark:bg-gray-800 dark:border-gray-700" placeholder="Email address" />
                        </div>

                        <div>
                            <label className="block mb-1">Message</label>
                            <textarea className="w-full px-4 py-2 border rounded-md bg-white dark:bg-gray-800 dark:border-gray-700" rows={5} placeholder="Your message" />
                        </div>

                        <button type="submit" className="px-6 py-3 bg-blue-600 text-white rounded-lg hover:bg-blue-700">
                            Send Message
                        </button>
                    </form>
                </section>

                <footer className="text-sm text-gray-600 dark:text-gray-400">
                    We respect your privacy. Your info will not be shared with any third party.
                </footer>
            </div>
        </div>
    );
}