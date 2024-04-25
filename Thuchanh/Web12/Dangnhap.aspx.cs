using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class Dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                if(Request.Form["txtNickName"] !=null && Request.Form["txtColor"] != null)
                {
                    string Ten = Request.Form["txtNickName"].ToString();
                    string mau = Request.Form["txtColor"].ToString();
                    if (Ten != "" || mau != "")
                    {
                        Member newMember = new Member(Ten, mau);
                        List<Member> listMember = (List<Member>)Application["ListMember"];
                        foreach (Member member in listMember)
                        {
                            if (member.Nickname == Ten)
                            {
                                Session["Member"] = newMember;
                                Response.Redirect("chatbox.aspx" + "?name=" + ((Member)Session["Member"]).Nickname);
                                return;
                            }
                        }
                    ((List<Member>)Application["ListMember"]).Add(newMember);
                        Session["Member"] = newMember;
                        Response.Redirect("chatbox.aspx" + "?name=" + ((Member)Session["Member"]).Nickname);
                    }
                    else
                    {
                        Response.Write("<script>alert('Không được để trống các ô')</script>");
                    }
                }
                
            }
        }
    }
}