using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    public class CapacityPlanWorkload
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("fte_time_conv")]
        public double FTETimeConv { get; set; }

        [Column("plan_aht")]
        public double PlanAHT { get; set; }

        [Column("concurency")]
        public double Concurency { get; set; }

        [Column("billable_fte")]
        public double BillableFTE { get; set; }

        [Column("hc_req")]
        public double HcReq { get; set; }

        [Column("prod_hr_req")]
        public double ProdHrReq { get; set; }

        [Column("sched_res_fac")]
        public double SchedResFac { get; set; }

        [Column("plan_agent_fte")]
        public double PlanAgentFTE { get; set; }

        [Column("plan_nes_fte")]
        public double PlanNesFTE { get; set; }

        [Column("date_from", TypeName = "varchar(200)")]
        public string DateFrom { get; set; }

        [Column("date_to", TypeName = "varchar(200)")]
        public string DateTo { get; set; }
    }
}
