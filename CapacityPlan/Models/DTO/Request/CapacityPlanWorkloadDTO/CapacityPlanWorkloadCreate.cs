namespace CapacityPlanApp.Models.DTO.Request.CapacityPlanWorkloadDTO
{
    public class CapacityPlanWorkloadCreate
    {
        public double FTETimeConv { get; set; }

        public double PlanAHT { get; set; }

        public double Concurency { get; set; }

        public double BillableFTE { get; set; }

        public double HcReq { get; set; }

        public double ProdHrReq { get; set; }

        public double SchedResFac { get; set; }

        public double PlanAgentFTE { get; set; }

        public double PlanNesFTE { get; set; }

        public string DateFrom { get; set; }

        public string DateTo { get; set; }
    }
}
