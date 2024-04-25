using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Xml;
using System.Web.UI.WebControls;

namespace Web09
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {

                string tenxvl = Request.Form["fname"];
                string hang = Request.Form["name"];
                string ngayramat = Request.Form["date"];
                string gia = Request.Form["gia"];

                XmlDocument xml = new XmlDocument();

                XmlElement root = xml.CreateElement("XML");

                XmlElement itemElement1 = xml.CreateElement("TenXVL");
                itemElement1.InnerText = tenxvl;
                root.AppendChild(itemElement1);

                XmlElement itemElement2 = xml.CreateElement("Hang");
                itemElement2.InnerText = hang;
                root.AppendChild(itemElement2);

                XmlElement itemElement3 = xml.CreateElement("NgayRaMat");
                itemElement3.InnerText = ngayramat;
                root.AppendChild(itemElement3);

                XmlElement itemElement4 = xml.CreateElement("Gia");
                itemElement4.InnerText = gia;
                root.AppendChild(itemElement4);
                xml.AppendChild(root);
                Response.Clear();
                Response.ContentType = "text/xml";
                xml.Save(Response.Output);
                Response.End();
            }
            if (Request.HttpMethod == "GET")
            {
                string tenxvl = Request.QueryString["fname"];
                string hang = Request.QueryString["name"];
                string ngayramat = Request.QueryString["date"];
                string gia = Request.QueryString["gia"];

                XmlDocument xml = new XmlDocument();

                XmlElement root = xml.CreateElement("XML");

                XmlElement itemElement1 = xml.CreateElement("TenXVL");
                itemElement1.InnerText = tenxvl;
                root.AppendChild(itemElement1);

                XmlElement itemElement2 = xml.CreateElement("Hang");
                itemElement2.InnerText = hang;
                root.AppendChild(itemElement2);

                XmlElement itemElement3 = xml.CreateElement("NgayRaMat");
                itemElement3.InnerText = ngayramat;
                root.AppendChild(itemElement3);

                XmlElement itemElement4 = xml.CreateElement("Gia");
                itemElement4.InnerText = gia;
                root.AppendChild(itemElement4);
                xml.AppendChild(root);
                Response.Clear();
                Response.ContentType = "text/xml";
                xml.Save(Response.Output);
                Response.End();
            }
        }
    }
}