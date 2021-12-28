using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Model_MVC.Models
{
    public class CustomerBinder:IModelBinder
    {
        public object BindModel(ControllerContext controllerContext,ModelBindingContext bindingContext)
        {
            string StudentId = controllerContext.HttpContext.Request.Form["StudentId"];
            string StudentName = controllerContext.HttpContext.Request.Form["StudentName"];
            string Street = controllerContext.HttpContext.Request.Form["Street"];
            string Dno = controllerContext.HttpContext.Request.Form["Dno"];
            return new Students() { StudentId =  StudentId , StudentName = StudentName, StudentAddress = Dno + " , " + Street };
        }
    }
}