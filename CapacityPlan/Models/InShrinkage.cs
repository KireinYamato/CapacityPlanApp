using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    public class InShrinkage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("planned_leave")]
        public double PlannedLeave { get; set; }

        [Column("fix_holiday")]
        public double FixHoliday { get; set; }

        [Column("opt_holiday")]
        public double OptHoliday { get; set; }

        [Column("sick_leave")]
        public double SickLeave { get; set; }

        [Column("unplanned_leave")]
        public double UnplannedLeave { get; set; }

        [Column("date_from", TypeName = "varchar(200)")]
        public string DateFrom { get; set; }

        [Column("date_to", TypeName = "varchar(200)")]
        public string DateTo { get; set; }
    }
}
