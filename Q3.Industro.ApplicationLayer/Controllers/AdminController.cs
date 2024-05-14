using Q3.Industro.BusinessLayer.BusinessProject;
using Q3.Industro.BusinessLayer.BusinessService;
using Q3.Industro.BusinessLayer.BusinessTeams;
using Q3.Industro.BusinessLayer.BusinessTestimonial;
using Q3.Industro.DataLayer.Data;
using Q3.Industro.DataLayer.DBOperation;
using Q3.Industro.ModelLayer.Models.Projects;
using Q3.Industro.ModelLayer.Models.Services;
using Q3.Industro.ModelLayer.Models.Teams;
using Q3.Industro.ModelLayer.Models.Testimonials;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Q3.Industro.ApplicationLayer.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private IndustroDbContext industroDbContext = new IndustroDbContext();
        ServiceLogic serviceLogic = new ServiceLogic();
        TeamLogic teamLogic = new TeamLogic();
        ProjectLogic projectLogic = new ProjectLogic();
        TestimonialLogic testimonialLogic = new TestimonialLogic();


        public ActionResult AdminIndex()
        {
            return View();
        }
        public ActionResult AllTeams()
        {
            var teamData = industroDbContext.TeamTable.ToList();
            return View(teamData);
        }
        public ActionResult AddTeam()
        {
            return View();
        }
        public ActionResult EditTeams(int id)
        {
            var teamedit = industroDbContext.TeamTable.Where(x => x.teamId == id).SingleOrDefault();
            return View(teamedit);
        }
        public ActionResult DeleteTeam(int id)
        {
            var teamDelete = industroDbContext.TeamTable.Where(x => x.teamId == id).SingleOrDefault();
            return View(teamDelete);
        }


        public ActionResult AllProjects()
        {
            var projectData = industroDbContext.ProjectTable.ToList();
            return View(projectData);
        }
        public ActionResult AddProject()
        {
            return View();
        }
        public ActionResult EditProjects(int id)
        {
            var projectedit = industroDbContext.ProjectTable.Where(x => x.Projectid == id).SingleOrDefault();
            return View(projectedit);
        }
        public ActionResult DeleteProject(int id)
        {
            var projectDelete = industroDbContext.ProjectTable.Where(x => x.Projectid == id).SingleOrDefault();
            return View(projectDelete);
        }
        public ActionResult AllTestimonials()
        {
            var testimonialData = industroDbContext.TestimonialTable.ToList();
            return View(testimonialData);
        }
        public ActionResult AddTestimonial()
        {
            return View();
        }
        public ActionResult EditTestimonials(int id)
        {
            var testimonialedit = industroDbContext.TestimonialTable.Where(x => x.ClientId == id).SingleOrDefault();
            return View(testimonialedit);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var testimonialDelete = industroDbContext.TestimonialTable.Where(x => x.ClientId == id).SingleOrDefault();
            return View(testimonialDelete);
        }

        public ActionResult AllServices()
        {
            var serviceData = industroDbContext.ServiceInformations.ToList();
            return View(serviceData);
        }
        public ActionResult AddService()
        {
            return View();
        }
        public ActionResult EditServices(int id)
        {
            var serviceEdit = industroDbContext.ServiceInformations.Where(x => x.ServiceId == id).SingleOrDefault();
            return View(serviceEdit);
        }
        public ActionResult DeleteService(int id)
        {
            var deleteEdit = industroDbContext.ServiceInformations.Where(x => x.ServiceId == id).SingleOrDefault();
            return View(deleteEdit);
        }
        public ActionResult AdminContact()
        {
            return View();
        }
        [HttpPost]
        [ActionName("AddTestimonial")]
        public JsonResult AddTestimonialApi(FormCollection formCollection)
        {
            var name = formCollection["ClientName"].ToString();
            var email = formCollection["ClientEmail"].ToString();
            var prof = formCollection["ClientProf"].ToString();
            var desc = formCollection["ClientDesc"].ToString();



            if (System.Web.HttpContext.Current.Request.Files.AllKeys.Any())

            {

                var pic = System.Web.HttpContext.Current.Request.Files["Clientavatar"];
                if (pic != null)
                {

                    HttpPostedFileBase filebase = new HttpPostedFileWrapper(pic);
                    var fileName = Path.GetFileName(filebase.FileName);

                    fileName = DateTime.Now.ToString("ddMNyyyylilmess") + fileName;
                    var path = "../UploadFile/" + fileName;
                    filebase.SaveAs(Server.MapPath("~/UploadFile/") + fileName);
                    TestimonialInformation testimonialInformation = new TestimonialInformation();
                    testimonialInformation.ClientName = name;
                    testimonialInformation.ClientEmail = email;
                    testimonialInformation.ClientProf = prof;
                    testimonialInformation.ClientDesc = desc;
                    testimonialInformation.ClientImgUrl = path;
                    testimonialInformation.ClientShow = true;
                    testimonialLogic.AddTestimonial(testimonialInformation);
                }
            }
            

            return Json(new { IsSubmitted = true, responsetext = "Your Record Added!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("EditTestimonials")]
        public JsonResult EditTestimonialApi(TestimonialInformation testimonialForm)
        {
            TestimonialInformation testimonialEditInformation = industroDbContext.TestimonialTable.Where(x => x.ClientId == testimonialForm.ClientId).SingleOrDefault();

            testimonialLogic.EditTestimonial(testimonialForm);

            return Json(new { IsSubmitted = true, responsetext = "Your Record Edited!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("DeleteTestimonial")]
        public JsonResult DeleteTestimonialApi(TestimonialInformation testimonialForm)
        {
            TestimonialInformation testimonialDelInformation = industroDbContext.TestimonialTable.Where(x => x.ClientId == testimonialForm.ClientId).SingleOrDefault();

            testimonialLogic.DeleteTestimonial(testimonialDelInformation);

            return Json(new { IsSubmitted = true, responsetext = "Your Record Deleted!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("AddProject")]
        public JsonResult AddProjectApi(FormCollection formCollection)
        {
            var name = formCollection["ProjectName"].ToString();
            var date = formCollection["ProjectDate"];
            var about = formCollection["ProjectAbout"].ToString();



            if (System.Web.HttpContext.Current.Request.Files.AllKeys.Any())

            {

                var pic = System.Web.HttpContext.Current.Request.Files["Projectavatar"];
                if (pic != null)
                {

                    HttpPostedFileBase filebase = new HttpPostedFileWrapper(pic);
                    var fileName = Path.GetFileName(filebase.FileName);

                    fileName = DateTime.Now.ToString("ddMNyyyylilmess") + fileName;
                    var path = "../UploadFile/" + fileName;
                    filebase.SaveAs(Server.MapPath("~/UploadFile/") + fileName);
                    ProjectInformation projectInformation = new ProjectInformation();
                    projectInformation.ProjectName = name;
                    projectInformation.ProjectDate = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    projectInformation.ProjectImgUrl = path;
                    projectInformation.ProjectShow = true;
                    projectLogic.AddProject(projectInformation);
                }
            }



            return Json(new { IsSubmitted = true, responsetext = "Your Record Added!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("EditProjects")]
        public JsonResult EditProjectApi(ProjectInformation projectForm)
        {
            ProjectInformation projectEditInformation = industroDbContext.ProjectTable.Where(x => x.Projectid == projectForm.Projectid).SingleOrDefault();

            projectLogic.EditProject(projectForm);

            return Json(new { IsSubmitted = true, responsetext = "Your Record Edited" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("DeleteProject")]
        public JsonResult DeleteProjectApi(ProjectInformation projectForm)
        {
            ProjectInformation projectDelInformation = industroDbContext.ProjectTable.Where(x => x.Projectid == projectForm.Projectid).SingleOrDefault();

            projectLogic.DeleteProject(projectDelInformation);

            return Json(new { IsSubmitted = true, responsetext = "Your Record Deleted!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("AddTeam")]
        public JsonResult AddTeamApi(FormCollection formCollection)
        {
            var name = formCollection["MemberTeam"].ToString();
            var head = formCollection["HeadTeam"].ToString();
            var pos = formCollection["PositionTeam"].ToString();
            var about = formCollection["AboutYouTeam"].ToString();
            

            
            if (System.Web.HttpContext.Current.Request.Files.AllKeys.Any())

            {

                var pic = System.Web.HttpContext.Current.Request.Files["Teamavatar"]; 
                if (pic != null)
                {

                    HttpPostedFileBase filebase = new HttpPostedFileWrapper(pic);
                    var fileName = Path.GetFileName(filebase.FileName);

                    fileName = DateTime.Now.ToString("ddMNyyyylilmess") + fileName;
                    var path = "../UploadFile/" + fileName;
                    filebase.SaveAs(Server.MapPath("~/UploadFile/") + fileName);
                    TeamInformation teamInformation = new TeamInformation();
                    teamInformation.teamMember = name;
                    teamInformation.teamPosition = pos;
                    teamInformation.teamHead = head;
                    teamInformation.teamImgUrl = path;
                    teamInformation.teamShow = true;
                    teamInformation.teamDuration = 0.3;
                    teamLogic.AddTeam(teamInformation);
                }
            }
            

            

            return Json(new { IsSubmitted = true, responsetext = "Record Added!!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("EditTeams")]

        public JsonResult EditTeamApi(TeamFormInformation teamForm)

        {
            TeamInformation teamEditInformation = industroDbContext.TeamTable.Where(x => x.teamId == teamForm.IdTeam).SingleOrDefault();
            teamEditInformation.teamMember = teamForm.MemberTeam;
            teamEditInformation.teamPosition = teamForm.PositionTeam;
            teamEditInformation.teamHead = teamForm.HeadTeam;
            teamEditInformation.teamShow = true;
            teamEditInformation.teamDuration = 0.3;
            teamLogic.EditTeam(teamEditInformation);


            return Json(new { IsSubmitted = true, responsetext = "Record Edited!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("DeleteTeam")]

        public JsonResult DeleteTeamApi(TeamFormInformation teamForm)

        {
            TeamInformation teamDeleteInformation = industroDbContext.TeamTable.Where(x => x.teamId == teamForm.IdTeam).SingleOrDefault();

            teamLogic.DeleteTeam(teamDeleteInformation);

            return Json(new { IsSubmitted = true, responsetext = "Record Deleted!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("AddService")]
        public JsonResult AddServiceApi(FormCollection formCollection)

        {
            var name = formCollection["NameService"].ToString();
            var date = formCollection["DateService"].ToString();
            var about = formCollection["DescService"].ToString();



            if (System.Web.HttpContext.Current.Request.Files.AllKeys.Any())

            {

                var pic = System.Web.HttpContext.Current.Request.Files["Serviceavatar"];
                if (pic != null)
                {

                    HttpPostedFileBase filebase = new HttpPostedFileWrapper(pic);
                    var fileName = Path.GetFileName(filebase.FileName);

                    fileName = DateTime.Now.ToString("ddMNyyyylilmess") + fileName;
                    var path = "../UploadFile/" + fileName;
                    filebase.SaveAs(Server.MapPath("~/UploadFile/") + fileName);
                    TeamInformation teamInformation = new TeamInformation();
                    ServiceInformation serviceInformation = new ServiceInformation();
                    serviceInformation.ServiceName = name;
                    serviceInformation.ServiceDate = DateTime.Parse(date); 
                    serviceInformation.ServiceDesc = about;
                    serviceInformation.ServiceImgUrl = path;
                    serviceInformation.ServiceShow = true;
                    serviceLogic.AddService(serviceInformation);
                }
            }
           
            return Json(new { IsSubmitted = true, responsetext = "Record Added!!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("EditServices")]
        public JsonResult EditServiceApi(ServiceFormInformation serviceForm)
        {
            ServiceInformation serviceEditInformation = industroDbContext.ServiceInformations.Where(x => x.ServiceId == serviceForm.IdService).SingleOrDefault();
            serviceEditInformation.ServiceName = serviceForm.NameService;
            serviceEditInformation.ServiceDate = serviceForm.DateService;
            serviceEditInformation.ServiceDesc = serviceForm.DescService;
            //teamInformation.teamImgUrl = "../Images/"+teamForm.ImgUrlTeam;

            serviceEditInformation.ServiceShow = true;
            serviceLogic.EditService(serviceEditInformation);


            return Json(new { IsSubmitted = true, responsetext = "Record Edited!" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("DeleteService")]
        public JsonResult DeleteServiceApi(ServiceFormInformation serviceForm)
        {

            ServiceInformation serviceDeleteInformation = industroDbContext.ServiceInformations.Where(x => x.ServiceId == serviceForm.IdService).SingleOrDefault();

            serviceLogic.DeleteService(serviceDeleteInformation);

            return Json(new { IsSubmitted = true, responsetext = "Record Deleted!" }, JsonRequestBehavior.AllowGet);
        }
    }


}