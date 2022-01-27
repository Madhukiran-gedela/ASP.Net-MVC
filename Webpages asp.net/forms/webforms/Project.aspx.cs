using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectFee;
namespace webforms
{
    public partial class Project : System.Web.UI.Page
    {
        public decimal BasePrice = 100.00m;
        protected void Page_Load(object sender, EventArgs e)
        {
            ltBasePrice.Text = BasePrice.ToString("C");
        }

        protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program states = new Program();
            decimal fee = states.GetFeeForState(ddlStates.SelectedValue);
            decimal finalPrice = BasePrice + fee;
            ItCustomPrice.Text = finalPrice.ToString("C");
        }
    }
}