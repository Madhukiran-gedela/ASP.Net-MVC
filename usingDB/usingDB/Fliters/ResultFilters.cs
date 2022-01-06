using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace usingDB.Fliters
{
    public class ResultFilters : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.NoOfVisitorsOfTheDay = 90;
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
        }
    }
}