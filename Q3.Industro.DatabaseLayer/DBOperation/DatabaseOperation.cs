using Microsoft.EntityFrameworkCore;
using Q3.Industro.DataLayer.Data;
using Q3.Industro.DataLayer.IDBOperation;
using Q3.Industro.ModelLayer.Models.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.DataLayer.DBOperation
{
    public class DatabaseOperation<T1> : IDatabaseOperation<T1> where T1 : class
    {
    
        private readonly IndustroDbContext industroDbContext = new IndustroDbContext()
;        
        public List<T1> GetAllRecords<T1>() where T1 : class
        {
            DbSet<T1> dbSet = industroDbContext.Set<T1>();
            return dbSet.ToList();
        }
       
        public void DeleteRecord(T1 objclass1)
        {
            industroDbContext.Remove(objclass1);
            industroDbContext.SaveChanges();
        }

        public void EditRecord(T1 objclass1)
        {
            industroDbContext.Update(objclass1);
            industroDbContext.SaveChanges();

        }



        public void AddRecord(T1 objclass1)
        {
            industroDbContext.Add(objclass1);
            industroDbContext.SaveChanges();
        }
    }
}
