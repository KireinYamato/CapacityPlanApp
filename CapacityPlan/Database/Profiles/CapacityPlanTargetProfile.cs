using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanTargetDTO;
using CapacityPlanApp.Models.DTO.Request.ChannelDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class CapacityPlanTargetProfile : Profile
    {
        public CapacityPlanTargetProfile()
        {
            CreateMap<CapacityPlanTarget, CapacityPlanTargetCreate>()
            .ReverseMap();

            CreateMap<CapacityPlanTarget, CapacityPlanTargetUpdate>()
            .ReverseMap();
        }
    }
}
