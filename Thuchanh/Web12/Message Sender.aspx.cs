using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class Message_Sender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                string loi = "Có những lôi là :\\n";
                bool kiemtra = true;
                if (Session["Member"] == null)
                {
                    kiemtra = false;
                    loi += "+ Không có tài khoản trong web\\n";
                }
                string nd = Request.Form["txtChat"];
                if (nd == null)
                {
                    kiemtra = false;
                    loi += "+ Không có nội dung để gửi\\n";
                }
                Member mb = null;
                if (kiemtra == true)
                {
                    string mesg = nd;
                    string nickname = Request.Form["name"];
                    List<Member> listMember = ((List<Member>)Application["ListMember"]);
                    foreach (Member member in listMember)
                    {
                        if (member.Nickname == nickname)
                        {
                            mb = member;
                        }
                    }
                    if (mb == null)
                    {
                        Response.Write("<script>alert('Vui lòng đăng nhập tài khoản')</script>");
                        return;
                    }
                    Message Tinnhan = new Message(mb, mesg, DateTime.Now);
                    ((List<Message>)Application["ListMessage"]).Add(Tinnhan);
                    Response.Redirect("HTML\\Message.html?name=" + mb.Nickname);
                }
                else
                {
                    Response.Write($"<script>alert(' {loi }')</script>");
                    Response.Redirect("HTML\\Message.html");
                }
            }
        }
    }
}