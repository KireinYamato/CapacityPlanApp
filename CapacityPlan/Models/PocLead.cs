using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    public class PocLead
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name", TypeName = "varchar(200)")]
        public string FirstName { get; set; }

        [Column("middle_name", TypeName = "varchar(200)")]
        public string MiddleName { get; set; }

        [Column("last_name", TypeName = "varchar(200)")]
        public string LastName { get; set; }
    }
}
