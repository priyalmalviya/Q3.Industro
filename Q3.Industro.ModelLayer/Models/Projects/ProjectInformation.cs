using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Projects
{
    public class ProjectInformation
    {
        [Key]
        public int Projectid { get; set; }
        public string ProjectImgUrl { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAbout { get; set; }
        public DateTime ProjectDate { get; set; }
        public bool ProjectShow { get; set; }
    }
}
