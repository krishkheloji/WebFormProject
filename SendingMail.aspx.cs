using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JunBatchWebFormProject
{
	public partial class SendingMail : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			string toEmail=TextBox1.Text, sub=TextBox2.Text, body=TextBox3.Text;
			sendMail(toEmail,sub,body);
        }

		public void sendMail(string toEmail,string sub,string body)
		{
			MailMessage mail = new MailMessage();
			mail.From = new MailAddress("krishsecured@gmail.com");
			mail.To.Add(toEmail);
			mail.Subject = sub;
			mail.Body = body;
			
			//if(FileUpload1.HasFile)
			//{
			//	string fn = FileUpload1.PostedFile.FileName;
			//	mail.Attachments.Add(new Attachment(FileUpload1.PostedFile.InputStream, fn));
			//}

            if (FileUpload1.HasFiles)
            {
				foreach(var file in FileUpload1.PostedFiles)
				{
                    string fn = file.FileName;
                    mail.Attachments.Add(new Attachment(file.InputStream, fn));
                }                
            }


            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
			smtp.Credentials = new NetworkCredential("krishsecured@gmail.com", "ocaawkxidxgzwlnq");
			smtp.Port = 587;
			smtp.EnableSsl = true;
			smtp.Send(mail);

			Response.Write("<script>alert('Mail Send Successfully')</script>");
		}
    }
}