using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webforms
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = string.Format("You said your Name is {0} and your age is {1} and your email is {2} and your favortiue color is {3}",
                txtName.Text, txtAge.Text, txtEmail.Text, ddlColor.SelectedValue);
            ltMessage.Text = message;
        }
    }
}