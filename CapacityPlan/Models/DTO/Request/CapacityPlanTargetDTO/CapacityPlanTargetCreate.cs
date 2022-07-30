namespace CapacityPlanApp.Models.DTO.Request.CapacityPlanTargetDTO
{
    public class CapacityPlanTargetCreate
    {
        public double ASA { get; set; }

        public double SLTarget { get; set; }

        public double ServiceTime { get; set; }

        public double AnswerRate { get; set; }

        public double ABARate { get; set; }

        public double AHTCap { get; set; }

        public double TicketPerHour { get; set; }

        public double IdealOcc { get; set; }

        public double Utilization { get; set; }

        public double ResRate { get; set; }

        public double LineADH { get; set; }

        public string DateFrom { get; set; }

        public string DateTo { get; set; }
    }
}
