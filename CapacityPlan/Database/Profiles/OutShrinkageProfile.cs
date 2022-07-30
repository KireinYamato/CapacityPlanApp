using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.GeographyDTO;
using CapacityPlanApp.Models.DTO.Request.OutShrinkageDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class OutShrinkageProfile : Profile
    {
        public OutShrinkageProfile()
        {
            CreateMap<OutShrinkage, OutShrinkageCreate>()
            .ReverseMap();

            CreateMap<OutShrinkage, OutShrinkageUpdate>()
            .ReverseMap();
        }
    }
}
