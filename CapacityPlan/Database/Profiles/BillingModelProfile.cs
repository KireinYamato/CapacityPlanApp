using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.BillingModelDTO;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class BillingModelProfile : Profile
    {
        public BillingModelProfile()
        {
            CreateMap<BillingModel, BillingModelCreate>()
            .ReverseMap();

            CreateMap<BillingModel, BillingModelUpdate>()
            .ReverseMap();
        }
    }

}
