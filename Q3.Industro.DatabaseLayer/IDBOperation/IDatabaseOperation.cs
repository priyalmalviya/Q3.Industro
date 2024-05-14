    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Industro.DataLayer.IDBOperation
{
    public interface IDatabaseOperation<T1>
    {
        
        void DeleteRecord(T1 objclass1);
        void EditRecord(T1 objclass1);

        List<T1> GetAllRecords<T1>() where T1 : class;

        void AddRecord(T1 objclass1);
    }

    
}
