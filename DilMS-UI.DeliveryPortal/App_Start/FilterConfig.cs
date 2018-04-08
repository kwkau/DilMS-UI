using System.Web;
using System.Web.Mvc;

namespace DilMS_UI.DeliveryPortal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
