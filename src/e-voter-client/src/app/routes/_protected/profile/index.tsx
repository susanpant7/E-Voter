import { useEffect, useState } from 'react';
import {createFileRoute} from "@tanstack/react-router";
import type {Profile} from "./profileType.ts";
import {getProfile} from "./profile.ts";
import Section from "../../../../componenets/UI/Section.tsx";
import Field from "../../../../componenets/UI/Field.tsx";
import StatusField from "../../../../componenets/UI/StatusField.tsx";

export const Route = createFileRoute('/_protected/profile/')({
    component: RouteComponent,
});

function RouteComponent() {
    return <Profile />;
}

function Profile() {
    const [profile, setProfile] = useState<Profile | null>(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        async function fetchProfile() {
            try {
                setLoading(true);
                setError(null);
                const data = await getProfile();
                setProfile(data);
            } catch (err: any) {
                setError(err.message || 'Failed to load profile');
            } finally {
                setLoading(false);
            }
        }

        fetchProfile();
    }, []);

    if (loading) {
        return (
            <div className="min-h-screen flex items-center justify-center bg-gray-100 dark:bg-gray-900">
                <span className="text-gray-700 dark:text-gray-300">Loading profile...</span>
            </div>
        );
    }

    if (error) {
        return (
            <div className="min-h-screen flex items-center justify-center bg-gray-100 dark:bg-gray-900">
                <span className="text-red-500">{error}</span>
            </div>
        );
    }

    if (!profile) return null;

    const fullName = [profile.firstName, profile.middleName, profile.lastName]
        .filter(Boolean)
        .join(' ');
    

    return (
        <div className="min-h-screen bg-gray-100 dark:bg-gray-900 p-6">
            <div className="max-w-3xl mx-auto bg-white dark:bg-gray-800 rounded-2xl shadow-lg p-8 space-y-8">
                {/* Header */}
                <div className="text-center">
                    <h1 className="text-3xl font-bold text-gray-900 dark:text-white">
                        {fullName}
                    </h1>
                    <p className="text-sm text-gray-500 dark:text-gray-400">
                        Voter Card: {profile.voterCardNumber}
                    </p>
                </div>

                {/* Personal Info */}
                <Section title="Personal Information">
                    <Field label="First Name" value={profile.firstName} />
                    <Field label="Middle Name" value={profile.middleName || '—'} />
                    <Field label="Last Name" value={profile.lastName} />
                    <Field label="Gender" value={profile.gender} />
                    <Field label="Mobile Number" value={profile.mobileNumber} />
                </Section>

                {/* Status */}
                <Section title="Account Status">
                    <StatusField label="Verified" value={profile.isVerified} />
                    <StatusField label="Active" value={profile.isActive} />
                    <Field
                        label="Registered At"
                        value={new Date(profile.registeredAt).toLocaleDateString()}
                    />
                </Section>

                {/* Location */}
                <Section title="Voting Location">
                    <Field label="Province" value={profile.provinceName} />
                    <Field label="District" value={`${profile.districtName} (${profile.districtCode})`} />
                    <Field label="Municipality" value={profile.municipalityName} />
                    <Field label="Ward" value={`${profile.wardName} (No. ${profile.wardNumber})`} />
                </Section>

                {/* Voting Place */}
                <Section title="Voting Place">
                    <Field label="Name" value={profile.votingPlaceName} />
                    <Field label="Address" value={profile.votingPlaceAddress} />
                </Section>
            </div>
        </div>
    );
}

