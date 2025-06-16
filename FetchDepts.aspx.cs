using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JunBatchWebFormProject
{
	public partial class FetchDepts : System.Web.UI.Page
	{
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(cs);
            conn.Open();

            if(!IsPostBack)
            {
                FetchDeptNames();
            }
        }

        public void FetchDeptNames()
        {
            string q = "exec FetchDept";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DropDownList1.DataSource = rd;
            DropDownList1.DataTextField = "dname";
            DropDownList1.DataValueField = "did";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string x = DropDownList1.SelectedValue;
            Label1.Text = x;
        }
    }
}