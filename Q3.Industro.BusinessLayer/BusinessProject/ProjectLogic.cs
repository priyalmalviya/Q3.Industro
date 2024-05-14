using Q3.Industro.DataLayer.Data;
using Q3.Industro.DataLayer.DBOperation;
using Q3.Industro.ModelLayer.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.BusinessLayer.BusinessProject
{
    public class ProjectLogic
    {
        private IndustroDbContext industroDbContext = new IndustroDbContext();
        DatabaseOperation<ProjectInformation> dbOperation = new DatabaseOperation<ProjectInformation>();
        public ProjectCollection GetProject()
        {
            ProjectCollection projectcollection = new ProjectCollection();
            DatabaseOperation<ProjectInformation> dbOperation = new DatabaseOperation<ProjectInformation>();


            var info = dbOperation.GetAllRecords<ProjectInformation>();
            foreach (var item in info)
            {

                projectcollection.Projects.Add(new ProjectInformation()
                {
                    Projectid = item.Projectid,
                    ProjectName = item.ProjectName,
                    ProjectImgUrl = item.ProjectImgUrl,
                    ProjectShow = item.ProjectShow,
                    ProjectAbout = item.ProjectAbout,
                    ProjectDate = item.ProjectDate,
                   

                });
            }

            return projectcollection;
        }
        public void AddProject(ProjectInformation newProject)
        {
            dbOperation.AddRecord(newProject);
        }
        public void EditProject(ProjectInformation newProject)
        {
            dbOperation.EditRecord(newProject);
        }
        public void DeleteProject(ProjectInformation newProject)
        {
            dbOperation.DeleteRecord(newProject);
        }

    }
}
