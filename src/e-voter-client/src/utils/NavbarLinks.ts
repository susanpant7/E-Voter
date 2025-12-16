import {userIsAdmin} from "../auth/jwt.ts";

export const publicLinks = [
    { name: "Home", path: "/" },
    { name: "Contact", path: "/contact" },
];

export const privateLinks = [
    { name: "Profile", path: "/profile" },
];

export const adminLinks = [
    { name: "Election Parties", path: "/election-parties" },
];

export const getUserNavbarLinks = (token:string|null) => {
    let nonAdminLinks = [...publicLinks, ...privateLinks];
    if (!token) { return [...publicLinks]}
    if(userIsAdmin(token)){
        return [...nonAdminLinks, ...adminLinks];
    }
    return nonAdminLinks;
}