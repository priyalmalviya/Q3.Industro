using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Services
{
    public class ServiceCollection
    {
        public ServiceCollection()
        {
            Services = new List<ServiceInformation>();

        }
        public List<ServiceInformation>Services { get; set; }
    }
}
