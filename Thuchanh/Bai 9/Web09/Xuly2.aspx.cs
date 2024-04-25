using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Xml;
using System.Web.UI.WebControls;

namespace Web09
{
    public partial class Xuly2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "GET")
            {
                string xmlfile = Server.MapPath("~/App_data/xuly.xml");
                XmlDocument xml = new XmlDocument();
                xml.Load(xmlfile);
                XmlNodeList personNodes = xml.SelectNodes("//Chip");
                foreach (XmlNode personNode in personNodes)
                {
                    string Tenxvl = personNode.SelectSingleNode("Ten").InnerText;
                    string hang = personNode.SelectSingleNode("Hang").InnerText;
                    string ngayramat = personNode.SelectSingleNode("Ngayramat").InnerText;
                    string gia = personNode.SelectSingleNode("Gia").InnerText;
                    fname.Text = Tenxvl;
                    name.Text = hang;
                    date.Text = ngayramat;
                    Gia.Text = gia; 
                    
                }
            }
        }
    }
}