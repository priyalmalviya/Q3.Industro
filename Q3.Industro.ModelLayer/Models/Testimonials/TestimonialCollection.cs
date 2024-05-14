using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.ModelLayer.Models.Testimonials
{
    public class TestimonialCollection
    {
        public TestimonialCollection()
        {
            Testimonials =new List<TestimonialInformation>();
        }
        public List<TestimonialInformation> Testimonials { get; set; }
    }
}
