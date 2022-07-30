using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.PocLeadDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class PocLeadProfile : Profile
    {
        public PocLeadProfile()
        {
            CreateMap<PocLead, PocLeadCreate>()
            .ReverseMap();

            CreateMap<PocLead, PocLeadUpdate>()
            .ReverseMap();
        }
    }

}
