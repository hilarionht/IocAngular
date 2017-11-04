using System.Web;
using System.Web.Mvc;

namespace Ioc_AngularSPA.Api
{
    public class FilterConfig
    {
        
        public static void RegisterGlobalFilter(GlobalFilterCollection filter)
        {
            filter.Add(new HandleErrorAttribute());
        }
    }
}
