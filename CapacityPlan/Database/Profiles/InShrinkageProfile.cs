using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.GeographyDTO;
using CapacityPlanApp.Models.DTO.Request.InShrinkageDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class InShrinkageProfile : Profile
    {
        public InShrinkageProfile()
        {
            CreateMap<InShrinkage, InShrinkageCreate>()
            .ReverseMap();

            CreateMap<InShrinkage, InShrinkageUpdate>()
            .ReverseMap();
        }
    }
}
