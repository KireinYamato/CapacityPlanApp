using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.DeliveryLeadDTO;
using CapacityPlanApp.Models.DTO.Request.ForVolumeDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class ForVolumeProfile : Profile
    {
        public ForVolumeProfile()
        {
            CreateMap<ForVolume, ForVolumeCreate>()
            .ReverseMap();

            CreateMap<ForVolume, ForVolumeUpdate>()
            .ReverseMap();
        }
    }
}
