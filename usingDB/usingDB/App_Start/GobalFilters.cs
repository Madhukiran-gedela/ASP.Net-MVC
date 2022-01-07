using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using usingDB.Fliters;
using System.Web.Routing;
using System.IO;

namespace usingDB.App_Start
{
    public class GobalFilters
    {
        public static void RegisterGobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new MyExpectionFliter());
            filters.Add(new HandleErrorAttribute() { ExceptionType = typeof(Exception), View = "Error" });
        }
    }
}