using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Services

{
    public class ServiceInformation
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceImgUrl { get; set; }
        public DateTime ServiceDate { get; set; }

        public string ServiceName { get; set; }

        public string ServiceDesc { get; set; }

        public bool ServiceShow { get; set; }
    }

}
