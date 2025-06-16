using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JunBatchWebFormProject
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            Label1.Text = "Page Load";
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id;
            string name;
            double salary;

            id = int.Parse(TextBox1.Text);
            name = TextBox2.Text;
            salary = double.Parse(TextBox3.Text);

            Label1.Text = $"ID is {id}, Name is {name} & Salary is {salary}";

        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(TextBox4.Text);
            b = int.Parse(TextBox5.Text);

            string choice = DropDownList1.SelectedValue;
            if(choice.Equals("+"))
            {
                c = a + b;
            }
            else if (choice.Equals("-"))
            {
                c = a - b;
            }
            else if (choice.Equals("*"))
            {
                c = a * b;
            }
            else
            {
                c = a / b;
            }

            Label2.Text = $"Ans : {c}";
        }
    }
}