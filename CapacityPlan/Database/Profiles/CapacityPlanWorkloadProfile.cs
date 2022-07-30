using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanWorkloadDTO;
using CapacityPlanApp.Models.DTO.Request.ChannelDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class CapacityPlanWorkloadProfile : Profile
    {
        public CapacityPlanWorkloadProfile()
        {
            CreateMap<CapacityPlanWorkload, CapacityPlanWorkloadCreate>()
            .ReverseMap();

            CreateMap<CapacityPlanWorkload, CapacityPlanWorkloadUpdate>()
            .ReverseMap();
        }
    }
}
