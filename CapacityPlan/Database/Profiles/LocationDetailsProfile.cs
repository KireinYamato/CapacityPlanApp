using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.LocationDetailsDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class LocationDetailsProfile : Profile
    {
        public LocationDetailsProfile()
        {
            CreateMap<LocationDetails, LocationDetailsCreate>()
            .ReverseMap();

            CreateMap<LocationDetails, LocationDetailsUpdate>()
            .ReverseMap();
        }
    }

}
