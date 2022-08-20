import { CapacityPlanStatus } from "src/app/core/enums/capacity-plan-status.enum";
import { CapacityPlanDetails } from "./capacity-plan-details.model";

export class CapacityPlanUpdate {
    capacityPlanDetails: CapacityPlanDetails;
    status: CapacityPlanStatus;

    constructor(){
        this.capacityPlanDetails = new CapacityPlanDetails();
    }
}