using System.Web;
using System.Web.Mvc;

namespace WebApProva2Lab2WevertonCouy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
