using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc.Mailer;
using System.Net.Mail;

namespace TestMvc.Mailers
{ 
    public class UserMailer : MailerBase, IUserMailer     
	{
		public UserMailer():
			base()
		{
			MasterName="_Layout";
		}

		
		public virtual MailMessage Welcome()
		{
			var mailMessage = new MailMessage{Subject = "Welcome"};
			
			mailMessage.To.Add("brady.thomas@rewardjunkie.co");
			ViewBag.Name = "Brady Thomas";
			PopulateBody(mailMessage, viewName: "Welcome");

			return mailMessage;
		}

		
		public virtual MailMessage PasswordReset()
		{
			var mailMessage = new MailMessage{Subject = "PasswordReset"};
			
			//mailMessage.To.Add("some-email@example.com");
			//ViewBag.Data = someObject;
			PopulateBody(mailMessage, viewName: "PasswordReset");

			return mailMessage;
		}

		
	}
}