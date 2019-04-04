using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.WebService;
using System.Diagnostics;
using System.Xml.Linq;

namespace WebApplication.Students
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 myService = new WebService1();
        string[] subjects;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = dataStudentName();
            ListBox1.DataSource = null;
            subjects = myService.getSubjects();
            for (int i = 0; i < subjects.Count(); i = i + 2)
            {
                ListBox1.Items.Add(subjects[i]);
                ListBox1.DataSource = subjects[i];
            }

            for (int i = 0; i < subjects.Count(); i = i + 2)
            {
                ListBox1.Items.Add(subjects[i]);
                ListBox1.DataSource = subjects[i];
            }

        }

        string dataStudentName()
        {
            string user = Request.Cookies["user"].Value;

            return myService.dataStudent(user)[1];
        }


        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("DocumentElement",

                    new XElement("Areas",
                        new XElement("area_id", "01"),
                        new XElement("descripcion", "HUANCAYO"))));
            



            Response.Clear();

            Response.ContentType = "text/xml";
            Response.Write("<?xml version='1.0' encoding=utf-8?>");
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Write(doc);
        }
    }

}