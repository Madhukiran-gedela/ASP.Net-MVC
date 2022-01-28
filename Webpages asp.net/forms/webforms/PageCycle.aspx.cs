using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webforms
{
    public partial class PageCycle : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            bool isPostBack = Page.IsPostBack;
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            lblInit.Text = "I Set this text during Page_Init";
        }
        protected void Page_InitCompleted(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPageLoad.Text = "I set this text during the page load this where we performed";
            if (Page.IsPostBack)
                lblPostBack.Text = "I set this text when the page posted back";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblButtonEvent.Text = "I set this text when my button Onclick event method is fired";
        }
        protected void Page_LoadCompleted(object sender, EventArgs e)
        {

        }
        protected void Page_PreRender(object sender, EventArgs e)
        {

        }
        protected void Page_Unload(object sender, EventArgs e)
        {

        }
    }
}