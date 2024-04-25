using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web11
{
    public partial class XuLy : System.Web.UI.Page
    {
        bool Kiemtratontai(string ten,int nam,string giotinh )
        {
            List<NhanVien> danhsach = (List<NhanVien>)Session["danhsach"];
            foreach(var item in danhsach)
            {
                if (item.hoten == ten&&item.namsinh==nam&&item.gioitinh==giotinh)
                {
                    Response.Write("<script>alert('Người dùng đã tồn tại')</script>");
                    return true;
                }
                
            }return false;
        }

            
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.HttpMethod == "POST")
            {
               
                string Ten = Request.Form["txtHoten"];
                int Namsinh = int.Parse(Request.Form["txtNamsinh"]);
                string Gioitinh = Request.Form["txtGioitinh"];
                
                if (Kiemtratontai(Ten, Namsinh, Gioitinh) == true)
                {
                    return;
                }
                else
                {
                    NhanVien Nhanvien = new NhanVien(Ten, Namsinh, Gioitinh);
                    List<NhanVien> danhsach = (List<NhanVien>)Session["danhsach"];

                    danhsach.Add(Nhanvien);

                    string Taobang = "<table border ='1'><tr><th>Họ và tên </th><th>Năm sinh</th><th>Giới Tính</th></tr>";

                    foreach (var item in danhsach)
                    {
                        Taobang += $"<tr><td>{item.hoten}</td><td>{item.namsinh}</td><td>{item.gioitinh}</td></tr>";
                    }
                    Taobang += "</table>";

                    Response.Write(Taobang);
                }
            }
        }
    }
}