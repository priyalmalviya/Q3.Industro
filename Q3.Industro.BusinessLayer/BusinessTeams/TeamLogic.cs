using Q3.Industro.DataLayer.Data;
using Q3.Industro.DataLayer.DBOperation;
using Q3.Industro.ModelLayer.Models.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.BusinessLayer.BusinessTeams
{
    public class TeamLogic
    {
        private IndustroDbContext industroDbContext = new IndustroDbContext();
        DatabaseOperation<TeamInformation> dbOperation = new DatabaseOperation<TeamInformation>();
        public TeamCollection GetTeam()
        {
            TeamCollection teamCollection = new TeamCollection();
           


            var info = dbOperation.GetAllRecords<TeamInformation>();
            foreach (var item in info)
            {

                teamCollection.Teams.Add(new TeamInformation()
                {
                    teamId = item.teamId,
                    teamMember = item.teamMember,
                    teamPosition = item.teamPosition,
                    teamImgUrl = item.teamImgUrl,
                    teamDuration = item.teamDuration,
                    teamHead = item.teamHead,
                    teamShow = item.teamShow,

                });
            }

            return teamCollection;
        }
        public void AddTeam(TeamInformation teamForm)
        {
            dbOperation.AddRecord(teamForm);
        }
        public void EditTeam(TeamInformation teamform)
        {
            dbOperation.EditRecord(teamform);
        }
        public void DeleteTeam(TeamInformation teamform)
        {
            dbOperation.DeleteRecord(teamform);
        }
    }
}

