using System.Web;
using System.Web.Mvc;

namespace DilMS_UI.Dispatch
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
