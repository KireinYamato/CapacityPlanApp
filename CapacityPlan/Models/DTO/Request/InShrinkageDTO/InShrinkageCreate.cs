namespace CapacityPlanApp.Models.DTO.Request.InShrinkageDTO
{
    public class InShrinkageCreate
    {
        public double PlannedLeave { get; set; }

        public double FixHoliday { get; set; }

        public double OptHoliday { get; set; }

        public double SickLeave { get; set; }

        public double UnplannedLeave { get; set; }

        public string DateFrom { get; set; }

        public string DateTo { get; set; }
    }
}
