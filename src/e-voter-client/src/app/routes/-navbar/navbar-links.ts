import type {User} from "../../../stores/authStore.ts";

export const publicLinks = [
    { label: "Home", path: "/", icon: "🏠"},
    { label: "Contact", path: "/contact", icon:"📞" },
];

export const privateLinks = [
    { label: "Profile", path: "/profile" , icon: "👤" },
];

export const adminLinks = [
    { label: "Election Parties", path: "/election-parties", icon: "️🗳️" },
    { label: "Voting Places", path: "/voting-places", icon: "🏛️" },
];

export const getUserNavbarLinks = (user: User | null) => {
    if (!user) return [...publicLinks];

    const nonAdminLinks = [...publicLinks, ...privateLinks];

    const isAdmin = user?.roles.some(role =>
        ["ADMIN", "SUPER_ADMIN"].includes(role)
    );
    
    if (isAdmin) {
        return [...nonAdminLinks, ...adminLinks];
    }

    return nonAdminLinks;
};