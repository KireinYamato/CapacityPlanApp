using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.GeographyDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class GeographyProfile : Profile
    {
        public GeographyProfile()
        {
            CreateMap<Geography, GeographyCreate>()
            .ReverseMap();

            CreateMap<Geography, GeographyUpdate>()
            .ReverseMap();
        }
    }

}
