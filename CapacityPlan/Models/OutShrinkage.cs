using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    public class OutShrinkage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("planned_break")]
        public double PlannedBreak { get; set; }

        [Column("planned_huddle")]
        public double PlannedHuddle { get; set; }

        [Column("planned_coaching")]
        public double PlannedCoaching { get; set; }

        [Column("planned_training")]
        public double PlannedTraining { get; set; }

        [Column("planned_sys_issue")]
        public double PlannedSysIssue { get; set; }

        [Column("planned_outbound_call")]
        public double PlannedOutboundCall { get; set; }

        [Column("planned_wellness")]
        public double PlannedWellness { get; set; }

        [Column("date_from", TypeName = "varchar(200)")]
        public string DateFrom { get; set; }

        [Column("date_to", TypeName = "varchar(200)")]
        public string DateTo { get; set; }
    }
}
