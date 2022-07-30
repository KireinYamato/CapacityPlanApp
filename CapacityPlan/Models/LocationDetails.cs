using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    public class LocationDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        // Foreign key   
        [ForeignKey("geography_id")]
        public virtual Geography Geography { get; set; }
        // Foreign key   
        [ForeignKey("country_id")]
        public virtual Country Country { get; set; }
        // Foreign key   
        [ForeignKey("city_id")]
        public virtual City City { get; set; }
    }
}
