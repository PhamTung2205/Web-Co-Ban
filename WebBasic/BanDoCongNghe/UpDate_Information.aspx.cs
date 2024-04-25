using Models.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BanDoCongNghe
{
    public partial class UpDate_Information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("index.aspx");
            }
            if(Request.HttpMethod == "POST")
            {
                User user = (User)Session["User"];

                string oldPass = Request.Form["old_pass"]?.ToString();
                string newPass = Request.Form["new_pass"]?.ToString();
                string confirmPass = Request.Form["confirm_pass"]?.ToString();


                if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
                {
                    ShowMessage("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                bool check1 = oldPass.Equals(user.password.ToString());
                if (!check1)
                {
                    ShowMessage("Mật khẩu không đúng");
                    return;

                }
                bool check2 = newPass.Equals(confirmPass);
                if (!check2)
                {
                    ShowMessage("Xác nhận mật khẩu mới không đúng");
                    return;

                }
                bool check3 = newPass.Length > 6;
                

                if (check3 == false )
                {
                    ShowMessage("Mật khẩu mới không hợp lệ. Mật khẩu mới phải có ít nhất 6 ký tự, bao gồm ít nhất một chữ số và một ký tự đặc biệt.");
                    return;
                }

                
                if (newPass != confirmPass)
                {
                    ShowMessage("Xác nhận mật khẩu mới không khớp.");
                    return;
                }

                // Lấy danh sách người dùng từ file JSON
                string pathUserJson = Server.MapPath("~/App_Data/Json/Users.json");
                List<User> users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(pathUserJson));

                // Tìm người dùng cần cập nhật mật khẩu
                User userToUpdate = users.FirstOrDefault(u => u.username == ((User)Session["User"]).username);

                // Cập nhật mật khẩu mới cho người dùng
                if (userToUpdate != null)
                {
                    userToUpdate.password = newPass;

                    // Lưu lại danh sách người dùng đã cập nhật vào tệp JSON
                    File.WriteAllText(pathUserJson, JsonConvert.SerializeObject(users));

                    ShowMessage("Mật khẩu đã được cập nhật thành công.");
                }
                else
                {
                    ShowMessage("Không tìm thấy người dùng để cập nhật mật khẩu.");
                }
            }
        }

       

        private void ShowMessage(string message)
        {
            // Hiển thị thông báo cho người dùng
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", $"alert('{message}');", true);
        }
    }
}