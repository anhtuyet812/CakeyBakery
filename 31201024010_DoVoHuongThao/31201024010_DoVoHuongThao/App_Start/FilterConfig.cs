using System.Web;
using System.Web.Mvc;

namespace _31201024010_DoVoHuongThao

{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
