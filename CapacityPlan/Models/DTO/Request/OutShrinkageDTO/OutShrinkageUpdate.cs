namespace CapacityPlanApp.Models.DTO.Request.OutShrinkageDTO
{
    public class OutShrinkageUpdate
    {
        public double PlannedBreak { get; set; }

        public double PlannedHuddle { get; set; }

        public double PlannedCoaching { get; set; }

        public double PlannedTraining { get; set; }

        public double PlannedSysIssue { get; set; }

        public double PlannedOutboundCall { get; set; }

        public double PlannedWellness { get; set; }

        public string DateFrom { get; set; }

        public string DateTo { get; set; }
    }
}
