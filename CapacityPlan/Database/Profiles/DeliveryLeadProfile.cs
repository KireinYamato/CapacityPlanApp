using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.DeliveryLeadDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class DeliveryLeadProfile : Profile
    {
        public DeliveryLeadProfile()
        {
            CreateMap<DeliveryLead, DeliveryLeadCreate>()
            .ReverseMap();

            CreateMap<DeliveryLead, DeliveryLeadUpdate>()
            .ReverseMap();
        }
    }
}
