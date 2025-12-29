import type {Profile} from "./profile.types.ts";
import {EndPoints} from "../../../../../api/endpoint-routes.ts";
import eVoterApi from "../../../../../api/e-voter-api.ts";

export const getProfile = async (): Promise<Profile> => {
    return eVoterApi.get(EndPoints.GetMyProfile);
};