using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace usingDB.Fliters
{
    public class Custmoerfliter : FilterAttribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.User.IsInRole("Employee") == false)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}