using System.Web;
using System.Web.Mvc;

namespace DoAn_Nhom12
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}