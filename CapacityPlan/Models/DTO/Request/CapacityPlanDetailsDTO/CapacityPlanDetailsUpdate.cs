using CapacityPlanApp.Models.DTO.Request.BillingModelDTO;
using CapacityPlanApp.Models.DTO.Request.ChannelDTO;
using CapacityPlanApp.Models.DTO.Request.LanguageDTO;
using CapacityPlanApp.Models.DTO.Request.LocationDetailsDTO;
using CapacityPlanApp.Models.DTO.Request.PeopleDetailsDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using CapacityPlanApp.Models.DTO.Request.WorkstreamDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO
{
    public class CapacityPlanDetailsUpdate
    {
        public string Name { get; set; }
        public int CapacityPlanRefId { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public virtual ProjectCreate Project { get; set; }
        public virtual WorkstreamCreate Workstream { get; set; }
        public virtual LanguageCreate Language { get; set; }
        public virtual ChannelCreate Channel { get; set; }
        public virtual BillingModelCreate BillingModel { get; set; }
        public virtual LocationDetailsCreate LocationDetails { get; set; }
        public virtual PeopleDetailsCreate PeopleDetails { get; set; }
    }
}
