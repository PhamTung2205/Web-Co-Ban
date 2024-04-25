using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai10
{
    public partial class Bai10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                if(txtNoidung.Value == "")
                {
                    Response.Write("<script>alert('Không được để trống')</script>");
                }
                else
                {
                    Response.Write($"<p>Nội dung bạn vừa nhập là : {txtNoidung.Value}</p>");
                }

                if (!txtFile.HasFile)
                {
                    Response.Write("<script>alert('Không có file để lưu')<script>");
                }

                HttpPostedFile postedFile = txtFile.PostedFile;

                if (postedFile.ContentLength > 0)
                {
                    string tenfile = Path.GetFileName(postedFile.FileName);
                    string luufile = Server.MapPath("~/App_Data/" + kiemtrafile(tenfile));
                    postedFile.SaveAs(luufile);
                    Response.Write("<script>alert('Lưu file thành công')</script>");
                }
            }

            string kiemtrafile(string tenfile)
            {
                string ten = tenfile.Split('.')[0];
                string duoifile = "";
                if (tenfile.Split('.').Length > 1)
                {
                    duoifile = tenfile.Split('.')[tenfile.Split('.').Length - 1];
                }
                if (File.Exists(Server.MapPath("~/App_Data/" + ten + '.' + duoifile)))
                {
                    int i = 1;
                    while (File.Exists(Server.MapPath("~/App_Data/" + ten + "(" + i.ToString() + ")"+'.' + duoifile)))
                    {
                        i++;
                    }
                    return ten + "(" + i.ToString() + ")"+'.' + duoifile;
                }

                return tenfile;
            }
        }
    }
}