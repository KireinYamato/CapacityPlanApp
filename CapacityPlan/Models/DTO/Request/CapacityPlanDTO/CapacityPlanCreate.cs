using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapacityPlanApp.Core.Enums;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanTargetDTO;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanWorkloadDTO;
using CapacityPlanApp.Models.DTO.Request.ForVolumeDTO;
using CapacityPlanApp.Models.DTO.Request.InShrinkageDTO;
using CapacityPlanApp.Models.DTO.Request.OutShrinkageDTO;

namespace CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO
{
    public class CapacityPlanCreate
    {
        public string WeekStart { get; set; }
        public CapacityPlanStatus Status { get; set; }

        public CapacityPlanDetailsCreate CapacityPlanDetails { get; set; }
        public CapacityPlanTargetCreate CapacityPlanTarget { get; set; }
        public CapacityPlanWorkloadCreate CapacityPlanWorkload { get; set; }
        public InShrinkageCreate InShrinkage { get; set; }
        public OutShrinkageCreate OutShrinkage { get; set; }
        public ForVolumeCreate ForVolume { get; set; }

        //IsDeleted
        public bool IsDeleted { get; set; }

        public CapacityPlanCreate()
        {
            IsDeleted = false;
        }
    }
}
