using CapacityPlanApp.Core.Enums;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanTargetDTO;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanWorkloadDTO;
using CapacityPlanApp.Models.DTO.Request.ForVolumeDTO;
using CapacityPlanApp.Models.DTO.Request.InShrinkageDTO;
using CapacityPlanApp.Models.DTO.Request.OutShrinkageDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO
{
    public class CapacityPlanUpdate
    {
        public string WeekStart { get; set; }
        public CapacityPlanStatus Status { get; set; }

        public CapacityPlanDetailsUpdate CapacityPlanDetails { get; set; }
        public CapacityPlanTargetUpdate CapacityPlanTarget { get; set; }
        public CapacityPlanWorkloadUpdate CapacityPlanWorkload { get; set; }
        public InShrinkageUpdate InShrinkage { get; set; }
        public OutShrinkageUpdate OutShrinkage { get; set; }
        public ForVolumeUpdate ForVolume { get; set; }

        //IsDeleted
        public bool IsDeleted { get; set; }

        public CapacityPlanUpdate()
        {
            IsDeleted = false;
        }
    }
}
