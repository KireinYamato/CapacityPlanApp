using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    public class ForVolume
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("date", TypeName = "varchar(200)")]
        public string Date { get; set; }

        [Column("volume", TypeName = "int(11)")]
        public int Volume { get; set; }
    }
}
