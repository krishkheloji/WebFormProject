using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JunBatchWebFormProject.User
{
	public partial class User : System.Web.UI.MasterPage
	{
		SqlConnection conn;
		protected void Page_Load(object sender, EventArgs e)
		{
            string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(cs);
            conn.Open();

            if (Session["Suser"]!=null)
			{
				string us = Session["Suser"].ToString();
				string q = $"exec FindUsernameByEmail '{us}'";
				SqlCommand cmd = new SqlCommand(q, conn);
				SqlDataReader rd = cmd.ExecuteReader();
				rd.Read();
				Label1.Text=rd["username"].ToString();
            }
			else
			{
				Response.Write("<script>alert('Need to Login');window.location.href='../LoginDB.aspx';</script>");
				//Response.Redirect("../LoginDB.aspx");
			}
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			Session.Abandon();
			Response.Redirect("../LoginDB.aspx");
        }
    }
}