using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.PeopleDetailsDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class PeopleDetailsProfile : Profile
    {
        public PeopleDetailsProfile()
        {
            CreateMap<PeopleDetails, PeopleDetailsCreate>()
            .ReverseMap();

            CreateMap<PeopleDetails, PeopleDetailsUpdate>()
            .ReverseMap();
        }
    }

}
