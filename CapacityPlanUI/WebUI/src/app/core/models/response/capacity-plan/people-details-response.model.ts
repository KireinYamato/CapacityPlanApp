import { DeliveryLeadResponse } from "./delivery-lead-response.model";
import { PocLeadResponse } from "./poc-lead-response.model";
import { WccLeadResponse } from "./wcc-lead-response.model";

export class PeopleDetailsResponse{
    deliveryLead: DeliveryLeadResponse;
    wccLead: WccLeadResponse;
    pocLead: PocLeadResponse;
}