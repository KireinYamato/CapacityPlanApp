
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapacityPlanApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CapacityPlanApp.Database
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CapacityPlan> CapacityPlan { get; set; }
        public DbSet<CapacityPlanDetails> CapacityPlanDetails { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Workstream> Workstream { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Channel> Channel { get; set; }
        public DbSet<BillingModel> BillingModel { get; set; }
        public DbSet<LocationDetails> LocationDetails { get; set; }
        public DbSet<Geography> Geography { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<PeopleDetails> PeopleDetails { get; set; }
        public DbSet<DeliveryLead> DeliveryLead { get; set; }
        public DbSet<WccLead> WccLead { get; set; }
        public DbSet<PocLead> PocLead { get; set; }
        public DbSet<CapacityPlanTarget> CapacityPlanTarget { get; set; }
        public DbSet<CapacityPlanWorkload> CapacityPlanWorkload { get; set; }
        public DbSet<InShrinkage> InShrinkage { get; set; }
        public DbSet<OutShrinkage> OutShrinkage { get; set; }
        public DbSet<ForVolume> ForVolume { get; set; }
    }
}
