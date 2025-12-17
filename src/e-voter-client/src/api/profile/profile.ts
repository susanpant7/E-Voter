import type {Profile} from "./profile.types.ts";
import eVoterApi from "../e-voter-api.ts";
import {EndPoints} from "../endpoint-routes.ts";

export const getProfile = async (): Promise<Profile> => {
    return eVoterApi.get(EndPoints.GetMyProfile);
};