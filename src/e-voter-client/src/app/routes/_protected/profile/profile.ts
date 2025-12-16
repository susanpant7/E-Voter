import type {Profile} from "./profileType.ts";
import eVoterApi from "../../../../api/axios.ts";
import {EndPoints} from "../../../../api/EndpointRoutes.ts";

export const getProfile = async (): Promise<Profile> => {
    return eVoterApi.get(EndPoints.MyProfile);
};