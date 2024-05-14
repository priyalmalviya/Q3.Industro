using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Teams
{
    public class TeamFormInformation
    {
        public int IdTeam { get; set; }
        public string MemberTeam { get; set; }

        public string HeadTeam { get; set; }

        public string PositionTeam { get; set; }

        public Image ImgTeam { get; set; }
        public string AboutYouTeam { get; set; }


    }
}
