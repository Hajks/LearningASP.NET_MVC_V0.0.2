using System.Web;
using System.Web.Mvc;

namespace LearningASP.NET_MVC_V0._0._2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
