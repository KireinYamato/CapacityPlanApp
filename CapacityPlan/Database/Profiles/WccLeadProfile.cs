using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using CapacityPlanApp.Models.DTO.Request.WccLeadDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class WccLeadProfile : Profile
    {
        public WccLeadProfile()
        {
            CreateMap<WccLead, WccLeadCreate>()
            .ReverseMap();

            CreateMap<WccLead, WccLeadUpdate>()
            .ReverseMap();
        }
    }

}
