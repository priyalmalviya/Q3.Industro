using System.Web;
using System.Web.Mvc;

namespace Q3.Industro.ApplicationLayer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
