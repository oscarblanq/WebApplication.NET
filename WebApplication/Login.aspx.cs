using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.webService;

namespace WebApplication
{
    public partial class Log_in : System.Web.UI.Page
    {
        WebService1 myService = new WebService1();
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // WebService1 myService = new WebService1();
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            Console.Write(myService.verifiedLogin("professor", "1234"));
            if ( myService.verifiedLogin(userName, password) )
            {
                /*

                if (Request.Cookies["user"] == null && Request.Cookies["pass"] == null)
                {
                    HttpCookie cookieUser = new HttpCookie("user", userName);
                    HttpCookie cookiePass = new HttpCookie("pass", password);
                    cookieUser.Expires = new DateTime(2019, 06, 25);
                    cookiePass.Expires = new DateTime(2019, 06, 25);
                    Response.Cookies.Add(cookieUser);
                    Response.Cookies.Add(cookiePass);
                }

                Response.Redirect("Student.aspx");*/

                // usernameTextBox.Text = myService.HelloWorld();
                if (myService.verifiedLogin("hola", "1234")) {
                    Response.Redirect("~/Students/Student.aspx");
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}