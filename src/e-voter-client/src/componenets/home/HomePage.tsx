export default function HomePage() {
    return (
        <div className="min-h-screen bg-gray-50 dark:bg-gray-900 flex flex-col">
            {/* Hero / Info Section */}
            <main className="flex flex-col grow justify-center items-center text-center px-4">
                <h2 className="text-4xl font-bold text-gray-800 dark:text-gray-100 mb-4">
                    Empowering Every Citizen
                </h2>

                <p className="text-lg text-gray-600 dark:text-gray-300 max-w-xl mb-6">
                    Your vote shapes the future of Nepal. Participate in the democratic
                    process easily and securely with the E-Voter App.
                </p>

                
                {/* Importance Section */}
                <div className="mt-12 max-w-3xl text-left">
                    <h3 className="text-2xl font-semibold text-gray-800 dark:text-gray-100 mb-4">
                        Why Is Voting Important?
                    </h3>

                    <ul className="space-y-3 text-gray-700 dark:text-gray-300 leading-relaxed">
                        <li>• Voting is the foundation of democracy and citizen participation.</li>
                        <li>• It gives every Nepali the power to choose responsible leadership.</li>
                        <li>• Encourages transparency, accountability, and good governance.</li>
                        <li>• Your vote helps shape policies that impact education, economy, and development.</li>
                        <li>• A strong voter turnout strengthens our nation’s democratic future.</li>
                    </ul>
                </div>
            </main>

            {/* Footer */}
            <footer className="py-4 text-center text-gray-500 dark:text-gray-400 text-sm">
                © {new Date().getFullYear()} E-Voter Nepal. All rights reserved.
            </footer>
        </div>

    );
}
