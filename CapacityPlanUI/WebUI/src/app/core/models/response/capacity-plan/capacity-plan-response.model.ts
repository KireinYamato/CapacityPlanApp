import { CapacityPlanDetailsResponse } from "./capacity-plan-details-response.model";
import { CapacityPlanTargetResponse } from "./capacity-plan-target-response.model";
import { CapacityPlanWorkloadResponse } from "./capacity-plan-workload-response.model";
import { InShrinkageResponse } from "./in-shrinkage-response.model";
import { OutShrinkageResponse } from "./out-shrinkage-response.model";

export class CapacityPlanResponse{
    weekStart: string;
    status: number;
    capacityPlanDetails: CapacityPlanDetailsResponse;
    capacityPlanTarget: CapacityPlanTargetResponse;
    capacityPlanWorkload: CapacityPlanWorkloadResponse;
    inShrinkage: InShrinkageResponse;
    outShrinkage: OutShrinkageResponse;
    // forVolume: ForVolumeResponse;

    constructor(){
        this.capacityPlanDetails = new CapacityPlanDetailsResponse();
        this.capacityPlanTarget = new CapacityPlanTargetResponse();
        this.capacityPlanWorkload = new CapacityPlanWorkloadResponse();
    }
}