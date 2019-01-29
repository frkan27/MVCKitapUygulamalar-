using System.Web;
using System.Web.Mvc;

namespace _7.MVC_CSS_Kullanımı
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
