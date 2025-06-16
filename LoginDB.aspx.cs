using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;

namespace JunBatchWebFormProject
{
	public partial class LoginDB : System.Web.UI.Page
	{
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(cs);
            conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string em=TextBox1.Text, pass=TextBox2.Text;
            string q = $"exec LoginProc '{em}','{pass}'";
            SqlCommand cmd = new SqlCommand(q,conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows)
            {
                Session["SUser"] = em;
                while (rdr.Read())
                {   
                    if ((rdr["email"].Equals(em) || rdr["username"].Equals(em)) && rdr["pass"].Equals(pass) && rdr["urole"].Equals("Admin"))
                    {
                        Response.Redirect("/Admin/AdminHome.aspx");
                    }

                    if ((rdr["email"].Equals(em) || rdr["username"].Equals(em)) && rdr["pass"].Equals(pass) && rdr["urole"].Equals("User"))
                    {
                        Response.Redirect("/User/UserHome.aspx");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid User');</script>");
            }
        }
    }
}