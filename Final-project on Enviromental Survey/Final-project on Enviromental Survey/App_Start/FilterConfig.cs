using System.Web;
using System.Web.Mvc;

namespace Final_project_on_Enviromental_Survey
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
