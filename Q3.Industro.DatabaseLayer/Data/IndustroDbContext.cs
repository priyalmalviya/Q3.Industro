using Microsoft.EntityFrameworkCore;
using Q3.Industro.ModelLayer.Models.Projects;
using Q3.Industro.ModelLayer.Models.Services;
using Q3.Industro.ModelLayer.Models.Teams;
using Q3.Industro.ModelLayer.Models.Testimonials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.DataLayer.Data

{
    public class IndustroDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAP-PRIYAL-MALV;Initial Catalog=EFCoreIndustro;User ID=sa;Password=Q3tech123");
        }
        public DbSet<ServiceInformation> ServiceInformations { get; set; }
        public DbSet<TeamInformation> TeamTable { get; set; }

        public DbSet<ProjectInformation> ProjectTable { get; set; }

        public DbSet<TestimonialInformation> TestimonialTable { get; set; }
    }
}
