using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    public class CapacityPlanTarget
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("asa")]
        public double ASA { get; set; }

        [Column("sl_target")]
        public double SLTarget { get; set; }

        [Column("service_time")]
        public double ServiceTime { get; set; }

        [Column("answer_rate")]
        public double AnswerRate { get; set; }

        [Column("aba_rate")]
        public double ABARate { get; set; }

        [Column("aht_cap")]
        public double AHTCap { get; set; }

        [Column("ticket_per_hr")]
        public double TicketPerHour { get; set; }

        [Column("ideal_occ")]
        public double IdealOcc { get; set; }

        [Column("utilization")]
        public double Utilization { get; set; }

        [Column("res_rate")]
        public double ResRate { get; set; }

        [Column("line_adh")]
        public double LineADH { get; set; }

        [Column("date_from", TypeName = "varchar(200)")]
        public string DateFrom { get; set; }

        [Column("date_to", TypeName = "varchar(200)")]
        public string DateTo { get; set; }
    }
}
