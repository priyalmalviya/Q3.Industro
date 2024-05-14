using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Teams
{
    public class TeamCollection
    {
        public TeamCollection()
        {
            Teams = new List<TeamInformation>();

        }
        public List<TeamInformation> Teams{ get; set; }
    }
}

