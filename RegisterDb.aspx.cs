using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JunBatchWebFormProject
{
	public partial class RegisterDb : System.Web.UI.Page
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
			string user=TextBox1.Text, em=TextBox2.Text, pass=TextBox3.Text, role="User";

			string q = $"exec RegisterUserProc '{user}','{em}','{pass}','{role}'";
			SqlCommand cmd = new SqlCommand(q,conn);
			cmd.ExecuteNonQuery();

			Response.Write("<script>alert('User Registered Successfully');window.location.href='LoginDB.aspx';</script>");
        }

		
    }
}