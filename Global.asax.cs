using System.Web;
using System.Web.Http;
using WebApiAutofacCrud;
using WebApiAutofacCrudPagination.Data;

namespace WebApiAutofacCrudPagination
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutofacWebApiConfig.Configure();
            ApplicationDbContext.Seed();
        }
    }
}