using Q3.Industro.ModelLayer.Models.Projects;
using Q3.Industro.ModelLayer.Models.Services;
using Q3.Industro.ModelLayer.Models.Teams;
using Q3.Industro.ModelLayer.Models.Testimonials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.HomePage
{
   public class HomePageCollection
    {
        public ServiceCollection ServiceList { get; set; }
        public TeamCollection TeamList { get; set; }
        public ProjectCollection ProjectList { get; set; }
        public TestimonialCollection TestimonialList { get; set; }
    }
}
