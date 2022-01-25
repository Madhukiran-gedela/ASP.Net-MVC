using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webforms
{
    public partial class Mypage : System.Web.UI.Page
    {
        private List<MyEvent> myEvent;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Session["MyEvent"] = new List<MyEvent>();
        }
        protected void btnEvent_Click(object sender, EventArgs e)
        {
            UpdateEvent();
        }
        private void UpdateEvent()
        {
            if (Session["MyEvent"] != null)
                myEvent = (List<MyEvent>)Session["MyEvent"];
            else
                myEvent = new List<MyEvent>();
            myEvent.Add(new MyEvent(txtEvent.Text, calendarEvents.SelectedDate));
            Session["MyEvent"] = myEvent;
        }
        private void BindEvents()
        {
            rptEvents.DataSource = myEvent;
            rptEvents.DataBind();
        }
    }
        public class MyEvent
        {
            public string EventName
            {
                get;
                private set;
            }
            public string EventDate
            {
                get;
                private set;
            }
            public MyEvent(string eventName, DateTime eventDate)
            {
                EventName = eventName;
                EventDate = eventDate.ToShortDateString();
            }
        }
}