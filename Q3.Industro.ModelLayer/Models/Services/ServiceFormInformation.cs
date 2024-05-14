using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Services
{
    public class ServiceFormInformation
    {
        public int IdService { get; set; }
        public string ImgUrlService { get; set; }
        public DateTime DateService { get; set; }

        public string NameService { get; set; }

        public string DescService { get; set; }
    }
}
