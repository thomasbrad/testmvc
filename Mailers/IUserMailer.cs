using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc.Mailer;
using System.Net.Mail;

namespace TestMvc.Mailers
{ 
    public interface IUserMailer
    {
				
		MailMessage Welcome();
		
				
		MailMessage PasswordReset();
		
		
	}
}