using System.Web;
using System.Web.Mvc;

namespace Aad.B2c.Poc.Yang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
