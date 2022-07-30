using CapacityPlanApp.Models.DTO.Request.DeliveryLeadDTO;
using CapacityPlanApp.Models.DTO.Request.PocLeadDTO;
using CapacityPlanApp.Models.DTO.Request.WccLeadDTO;

namespace CapacityPlanApp.Models.DTO.Request.PeopleDetailsDTO
{
    public class PeopleDetailsCreate
    {
        public virtual DeliveryLeadCreate DeliveryLead { get; set; }
        public virtual WccLeadCreate WccLead { get; set; }
        public virtual PocLeadCreate PocLead { get; set; }
    }
}
