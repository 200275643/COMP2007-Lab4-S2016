using System.Web;
using System.Web.Mvc;

namespace COMP2007_Lab4_S2016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
