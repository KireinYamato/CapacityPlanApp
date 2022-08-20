import { BillingModelResponse } from "./billing-model-response.model";
import { ChannelResponse } from "./channel-response.model";
import { LanguageResponse } from "./language-response.model";
import { LocationDetailsResponse } from "./location-details-response.model";
import { PeopleDetailsResponse } from "./people-details-response.model";
import { ProjectResponse } from "./project-response.model";
import { WorkstreamResponse } from "./workstream-response.model";

export class CapacityPlanDetailsResponse {
    id: number; 
    name: string;
    capacityPlanRefId: number;
    dateFrom: string;
    dateTo: string;
    project: ProjectResponse;
    workstream: WorkstreamResponse;
    language: LanguageResponse;
    channel: ChannelResponse;
    billingModel: BillingModelResponse;
    locationDetails: LocationDetailsResponse;
    peopleDetails: PeopleDetailsResponse;
}