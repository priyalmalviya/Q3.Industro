using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



using Q3.Industro.ApplicationLayer;
using Q3.Industro.ModelLayer.Models.Services;

using Microsoft.Extensions.Logging;
using Q3.Industro.BusinessLayer.BusinessService;
using Q3.Industro.ModelLayer.Models.HomePage;
using Q3.Industro.ModelLayer.Models.Teams;
using Q3.Industro.BusinessLayer.BusinessTeams;
using Q3.Industro.BusinessLayer.BusinessProject;
using Q3.Industro.ModelLayer.Models.Projects;
using Q3.Industro.BusinessLayer.BusinessTestimonial;
using Q3.Industro.ModelLayer.Models.Testimonials;
using Q3.Industro.ModelLayer.Models.Contact;
using System.Text;
using System.Net.Mail;
using System.Net;
using Q3.Industro.DataLayer.Data;

namespace Q3.Industro.ApplicationLayer.Controllers
{
    public class HomeController : Controller
    {
        private IndustroDbContext industroDbContext = new IndustroDbContext();
        ServiceLogic serviceLogic = new ServiceLogic();
        TeamLogic teamLogic = new TeamLogic();
        ProjectLogic projectLogic = new ProjectLogic();
        TestimonialLogic testimonialLogic = new TestimonialLogic();

        public ActionResult Index()
        {

            HomePageCollection homePageCollection = new HomePageCollection();
            homePageCollection.ServiceList = serviceLogic.GetService();
            homePageCollection.TeamList = teamLogic.GetTeam();
            homePageCollection.ProjectList = projectLogic.GetProject();
            homePageCollection.TestimonialList = testimonialLogic.GetTestimonial();
            
            return View(homePageCollection);
        }

       public ActionResult About()
        {
            ViewBag.Message = "Your About Page";
            return View();
        }
        public ActionResult Service()
        {
            var serviceData = new ServiceCollection();
            serviceData = serviceLogic.GetService();
            return View(serviceData);
            
        }
        public ActionResult ServiceMore(int id)
        {
            var model = industroDbContext.ServiceInformations.ToList().Where(x => x.ServiceId == id).SingleOrDefault();
            return View(model);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your Contact Page";
            return View();
        }
        public ActionResult Error404()
        {
            ViewBag.Message = "Your Error Page";
            return View();
        }
        public ActionResult OurTeam()
        {
            var teamData = new TeamCollection();
            teamData = teamLogic.GetTeam();
            return View(teamData);
        }
        public ActionResult Feature()
        {
            ViewBag.Message = "Your Feature Page";
            return View();
        }

        public ActionResult Project()
        {
            var projectData = new ProjectCollection();
            projectData = projectLogic.GetProject();
            return View(projectData);
        }
        public ActionResult Testimonial()
        {
            var clientData = new TestimonialCollection();
            clientData = testimonialLogic.GetTestimonial();
            return View(clientData);
        }
        public ActionResult Login_Register()
        {
            ViewBag.Message = "Your Login_Register page.";

            return View();
        }
        [HttpPost]
        [ActionName("Contact")]
        public JsonResult ContactApi(SenderInformation senderInformation)
        {
           

            string Name = senderInformation.SenderName;
            string Email = senderInformation.SenderEmail;
            string Subject = senderInformation.SenderSubject;
            string Message = senderInformation.SenderMessage;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<table>");
            stringBuilder.Append("<tr><td>Name:</td><td>" + Name + "</td></tr>");
            stringBuilder.Append("<tr><td>Email:</td><td>" + Email + "</td></tr>");
            stringBuilder.Append("<tr><td>Subject:</td><td>" + Subject + "</td></tr>");
            stringBuilder.Append("<tr><td>Description:  </td><td>" + Message + "</td></tr>");
            stringBuilder.Append("</table>");

            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("bc7f69873924b2", "ce14d91f9a19c5"),
                EnableSsl = true
            };

            using (var message = new MailMessage())
            {
                message.From = new MailAddress(
                senderInformation.SenderEmail,
                senderInformation.SenderName

            );
                message.To.Add(new MailAddress(
                     "priyalq3tech@gmail.com",
                      "Priyal Malviya"

                ));
                message.Subject = senderInformation.SenderSubject;
                var htmlBody = stringBuilder.ToString();


                message.Body = htmlBody;
                message.IsBodyHtml = true;

                client.Send(message);
            }
            
            Console.WriteLine("Sent");

            return Json(new { IsSubmitted = true, responsetext = "Message Sent!" }, JsonRequestBehavior.AllowGet);
        }
    }
}