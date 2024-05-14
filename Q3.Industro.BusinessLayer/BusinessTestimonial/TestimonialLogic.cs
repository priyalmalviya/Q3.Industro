using Q3.Industro.DataLayer.Data;
using Q3.Industro.DataLayer.DBOperation;
using Q3.Industro.ModelLayer.Models.Testimonials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.BusinessLayer.BusinessTestimonial
{
    public class TestimonialLogic
    {
        private IndustroDbContext industroDbContext = new IndustroDbContext();
        DatabaseOperation<TestimonialInformation> dbOperation = new DatabaseOperation<TestimonialInformation>();
        public TestimonialCollection GetTestimonial()
        {
            TestimonialCollection testimonialCollection = new TestimonialCollection();
           


            var info = dbOperation.GetAllRecords<TestimonialInformation>();
            foreach (var item in info)
            {

                testimonialCollection.Testimonials.Add(new TestimonialInformation()
                {
                    ClientId = item.ClientId,
                    ClientName = item.ClientName,
                    ClientDesc = item.ClientDesc,
                    ClientProf = item.ClientProf,
                    ClientImgUrl = item.ClientImgUrl,
                    ClientEmail =item.ClientEmail,
                    ClientShow = item.ClientShow,
                
                });
            }

            return testimonialCollection;
        }
        public void AddTestimonial(TestimonialInformation newTestimonial)
        {
            
           dbOperation.AddRecord(newTestimonial);
        }
        public void EditTestimonial(TestimonialInformation newTestimonial)
        {
            dbOperation.EditRecord(newTestimonial);
        }
        public void DeleteTestimonial(TestimonialInformation newTestimonial)
        {
            dbOperation.DeleteRecord(newTestimonial);
        }
    }
}

