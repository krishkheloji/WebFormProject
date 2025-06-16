using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JunBatchWebFormProject
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			string user=TextBox1.Text, pass=TextBox2.Text;
			if(user.Equals(pass))
			{
				Response.Redirect("Welcome.aspx");
			}
			else
			{
				Response.Write("<script>alert('Invalid Username or Password')</script>");
			}
        }
    }
}