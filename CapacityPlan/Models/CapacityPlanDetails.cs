using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    [Table("capacity_plan_details")]
    public class CapacityPlanDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("capacity_plan_ref_id", TypeName = "int(11)")]
        public int CapacityPlanRefId { get; set; }

        [Column("name", TypeName = "varchar(200)")]
        public string Name { get; set; }

        [Column("date_from", TypeName = "varchar(200)")]
        public string DateFrom { get; set; }

        [Column("date_to", TypeName = "varchar(200)")]
        public string DateTo { get; set; }

        // Foreign key   
        [ForeignKey("project_id")]
        public virtual Project Project { get; set; }

        // Foreign key   
        [ForeignKey("workstream_id")]
        public virtual Workstream Workstream { get; set; }

        // Foreign key   
        [ForeignKey("language_id")]
        public virtual Language Language { get; set; }

        // Foreign key   
        [ForeignKey("channel_id")]
        public virtual Channel Channel { get; set; }

        // Foreign key   
        [ForeignKey("billing_model_id")]
        public virtual BillingModel BillingModel { get; set; }

        // Foreign key   
        [ForeignKey("location_id")]
        public virtual LocationDetails LocationDetails { get; set; }

        // Foreign key   
        [ForeignKey("people_id")]
        public virtual PeopleDetails PeopleDetails { get; set; }
    }
}
