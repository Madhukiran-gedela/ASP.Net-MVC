using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using usingDB.App_Start;

namespace usingDB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GobalFilters.RegisterGobalFilters(GlobalFilters.Filters);
        }
        protected void Application_Error()
        {
            Exception exp = Server.GetLastError();
            string s = "Message:" + exp.Message + " , Type" + exp.GetType().ToString() + ", Source" + exp.Source;
            StreamWriter sw = File.AppendText(HttpContext.Current.Request.PhysicalApplicationPath + "\\ErrorLog.txt");
            sw.WriteLine(s);
            sw.Close();
            Response.Redirect("Error.html");
        }
    }
}
