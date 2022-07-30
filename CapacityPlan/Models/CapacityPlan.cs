using CapacityPlanApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{

    [Table("capacity_plan")]
    public class CapacityPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("week_start", TypeName = "varchar(200)")]
        public string WeekStart { get; set; }

        [Column("status", TypeName = "int(11)")]
        public CapacityPlanStatus Status { get; set; }

        // Foreign key   
        [ForeignKey("cp_details_id")]
        public virtual CapacityPlanDetails CapacityPlanDetails { get; set; }

        // Foreign key   
        [ForeignKey("cp_workload_id")]
        public virtual CapacityPlanWorkload CapacityPlanWorkload { get; set; }

        // Foreign key   
        [ForeignKey("cp_target_id")]
        public virtual CapacityPlanTarget CapacityPlanTarget { get; set; }
        /*
        // Foreign key   
        [ForeignKey("cp_hoop_id")]
        public virtual CapacityHoop CapacityHoop { get; set; }*/

        // Foreign key   
        [ForeignKey("cp_in_shrink_id")]
        public virtual InShrinkage InShrinkage { get; set; }

        // Foreign key   
        [ForeignKey("cp_out_shrink_id")]
        public virtual OutShrinkage OutShrinkage { get; set; } 

        // Foreign key   
        [ForeignKey("cp_volume_id")]
        public virtual ForVolume ForVolume { get; set; }

        // IsDeleted
        [Column("is_deleted", TypeName = "tinyint(1)")]
        public bool IsDeleted { get; set; }

        public CapacityPlan()
        {
            IsDeleted = false;
        }

    }
}
