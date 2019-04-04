using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.WebService;


namespace WebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        WebService1 myService = new WebService1();

        //Data students
        List<string> dataStudents = new List<string>();
        List<string> names = new List<string>();
        //string[] names;
        string[] surname;
        string[] age;
        string[] address;
        string[] dni;        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.Cookies["user"].Value;
            string[] alumno1 = myService.dataStudent("alumno@upv.es");
            names.Add(alumno1[1]);
            for(int i = 0; i< alumno1.Count(); i++)
            {
                dataStudents.Add(alumno1[i]);
            }
            string[] alumno2 = myService.dataStudent("gabi@upv.es");
            names.Add(alumno2[1]);
            for (int i = 0; i< alumno2.Count(); i++)
            {
                dataStudents.Add(alumno2[i]);
            }
            string[] alumno3 = myService.dataStudent("dayana@upv.es");
            names.Add(alumno3[1]);
            for (int i = 0; i<alumno3.Count(); i++)
            {
                dataStudents.Add(alumno3[i]);
            }

            for (int i = 0; i < names.Count(); i++){
                nameStudents.Items.Add(names[i].ToString());
            }

            TextBox1.Text = dataStudents[1];

        }

        protected void nameStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = nameStudents.SelectedItem.ToString();
            
            if(nameStudents.SelectedIndex == 1)
            {
                TextBox1.Text = dataStudents[1];

                TextBox2.Text = dataStudents[2];

                TextBox3.Text = dataStudents[3];

                TextBox4.Text = dataStudents[4];

                TextBox5.Text = dataStudents[5];

            }
        }

    }
}