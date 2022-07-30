using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using CapacityPlanApp.Models.DTO.Request.WorkstreamDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class WorkstreamProfile : Profile
    {
        public WorkstreamProfile()
        {
            CreateMap<Workstream, WorkstreamCreate>()
            .ReverseMap();

            CreateMap<Workstream, WorkstreamUpdate>()
            .ReverseMap();
        }
    }

}
