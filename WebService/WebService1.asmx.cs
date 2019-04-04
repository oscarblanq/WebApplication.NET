using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SQLite;
using System.Diagnostics;
using System.Data;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public string DBpath = AppDomain.CurrentDomain.BaseDirectory + "database.db";

        [WebMethod]
        public void addStudent(string _id, string name, string surname, int age, string address, int dni)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("INSERT INTO 'Students' (_id, name, surname, age, address, dni)" +
                    " VALUES ('" + _id + "', '" + name + "', '" + surname + "', '" + age + "', '" + address +
                    "', '" + dni + "');", conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.InsertCommand = comm;
                da.InsertCommand.ExecuteNonQuery();
            }
        }

        [WebMethod]
        public void editStudent(string _id, string name, string surname, int age, string address, int dni)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("UPDATE 'Students' SET _id = '" + _id + "'" +
                    ", name = '" + name + "', surname = '" + surname + "' , age = '" + age + "' , address = '" + address + "' , dni = '" + dni + "'  WHERE _id = '" + _id + "';", conn);

                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.InsertCommand = comm;
                da.InsertCommand.ExecuteNonQuery();
            }
        }

        [WebMethod]
        public int verifiedLogin(string user, string password)
        {
            int rol = 0;

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();

                String query = "SELECT * FROM Users WHERE username = '" + user + "' AND password='" + password + "';";

                SQLiteCommand comm = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = comm.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    foreach (DataRow dr in dt.Rows)
                    {
                        rol = Convert.ToInt32(dr["rol"]);
                    }
                }
            }
            return rol;
        }
        

        [WebMethod]
        public List<string> dataStudent(string alumno)
        {
            List<string> dataStudent = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();

                String query = "SELECT * FROM Students WHERE _id = '" + alumno + "';";

                SQLiteCommand comm = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = comm.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    foreach (DataRow dr in dt.Rows)
                    {

                        dataStudent.Add(dr["_id"].ToString());

                        dataStudent.Add(dr["name"].ToString());

                        dataStudent.Add(dr["surname"].ToString());

                        dataStudent.Add(dr["age"].ToString());

                        dataStudent.Add(dr["address"].ToString());

                        dataStudent.Add(dr["dni"].ToString());

                    }
                }
                return dataStudent;
            }
        }

        [WebMethod]
        public List<string> getSubjects()
        {
            List<string> subjects = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();

                String query = "SELECT * FROM Subjects;";

                SQLiteCommand comm = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = comm.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    foreach (DataRow dr in dt.Rows)
                    {
                        subjects.Add(dr["name"].ToString());
                        subjects.Add(dr["classroom"].ToString());
                    }
                }
            }
            return subjects;
        }
    }
}
