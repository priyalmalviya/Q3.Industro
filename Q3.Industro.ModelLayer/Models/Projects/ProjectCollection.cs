using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Projects
{
    public class ProjectCollection
    {
        public ProjectCollection()
        {
            Projects = new List<ProjectInformation>();
        }
        public List<ProjectInformation> Projects { get; set; }
    }
}
