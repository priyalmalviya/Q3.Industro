using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Teams
{
   public class TeamInformation
    {
        [Key]
        public int teamId { get; set; }

        public double teamDuration { get; set; }

        public string teamMember { get; set; }

        public string teamHead { get; set; }

        public string teamPosition { get; set; }

        public string teamImgUrl { get; set; }

        public bool teamShow { get; set; }

    }
}
