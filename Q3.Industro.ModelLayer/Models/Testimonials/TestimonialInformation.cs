using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Testimonials
{
    public class TestimonialInformation
    {
        [Key]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientDesc { get; set; }
        public string ClientProf { get; set; }
        public string ClientImgUrl { get; set; }
        public bool ClientShow { get; set; }


    }
}
