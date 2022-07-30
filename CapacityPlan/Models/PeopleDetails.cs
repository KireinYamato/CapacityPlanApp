using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    public class PeopleDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        // Foreign key   
        [ForeignKey("delivery_lead")]
        public virtual DeliveryLead DeliveryLead { get; set; }
        // Foreign key   
        [ForeignKey("wcc_lead")]
        public virtual WccLead WccLead { get; set; }
        // Foreign key   
        [ForeignKey("poc_lead")]
        public virtual PocLead PocLead { get; set; }
    }
}
