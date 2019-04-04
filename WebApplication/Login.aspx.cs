using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.WebService;
using System.Diagnostics;

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
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            int codeUser = myService.verifiedLogin(userName, password);

            if (codeUser == 0)
            {
                usernameTextBox.Text = "incorrect password";
            }

            if (codeUser == 1)
            {
                if (Request.Cookies["user"] == null)
                {
                    HttpCookie cookieUser = new HttpCookie("user", userName);
                    cookieUser.Expires = new DateTime(2019, 06, 25);
                    Response.Cookies.Add(cookieUser);
                }
                Response.Redirect("~/Professors/Professor.aspx");
            
        }

            if(codeUser == 2)
            {
                if (Request.Cookies["user"] == null)
                {
                    HttpCookie cookieUser = new HttpCookie("user", userName);
                    cookieUser.Expires = new DateTime(2019, 06, 25);
                    Response.Cookies.Add(cookieUser);
                }
                Response.Redirect("~/Professors/Professor.aspx");
            }

            if(codeUser == 3)
            {
                if (Request.Cookies["user"] == null)
                {
                    HttpCookie cookieUser = new HttpCookie("user", userName);
                    cookieUser.Expires = new DateTime(2019, 06, 25);
                    Response.Cookies.Add(cookieUser);
                }
                Response.Redirect("~/Students/Student.aspx");
            }
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}