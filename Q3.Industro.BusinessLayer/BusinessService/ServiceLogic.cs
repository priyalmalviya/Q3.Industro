using Q3.Industro.DataLayer.Data;
using Q3.Industro.DataLayer.DBOperation;
using Q3.Industro.ModelLayer.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.BusinessLayer.BusinessService
{
   public class ServiceLogic
    {
        private IndustroDbContext industroDbContext = new IndustroDbContext();
        DatabaseOperation<ServiceInformation> dbOperation = new DatabaseOperation<ServiceInformation>();
        public ServiceCollection GetService()
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            DatabaseOperation<ServiceInformation> dbOperation = new DatabaseOperation<ServiceInformation>();


            var info = dbOperation.GetAllRecords<ServiceInformation>();
            foreach (var item in info)
            {

                serviceCollection.Services.Add(new ServiceInformation()
                {
                    ServiceId = item.ServiceId,
                    ServiceName = item.ServiceName,
                    ServiceDesc = item.ServiceDesc,
                    ServiceImgUrl = item.ServiceImgUrl,
                    ServiceShow = item.ServiceShow,
                    ServiceDate = item.ServiceDate,
                
                });
            }

            return serviceCollection;
        }
        public void AddService(ServiceInformation serviceForm)
        {
            dbOperation.AddRecord(serviceForm);
        }
        public void EditService(ServiceInformation serviceform)
        {
            dbOperation.EditRecord(serviceform);
        }
        public void DeleteService(ServiceInformation Serviceform)
        {
            dbOperation.DeleteRecord(Serviceform);
        }
    }
}
