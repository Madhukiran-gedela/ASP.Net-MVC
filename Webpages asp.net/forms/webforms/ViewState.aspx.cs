using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectFee;
namespace webforms
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                ltPostBack.Text = ("I'am a post back! This form is \"sticky\" and your input");
            else
                ltPostBack.Text = ("Fill out the form");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}