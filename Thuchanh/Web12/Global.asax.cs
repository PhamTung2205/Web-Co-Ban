using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Web12
{
    public class Global : System.Web.HttpApplication
    {
        /* application : thực hiện khi web được load lại*/
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["ListMember"] = new List<Member>();
            Application["ListMessage"] = new List<Message>();
        }
        /*Session : khi được sd trong web*/
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Member"] = new Member();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}