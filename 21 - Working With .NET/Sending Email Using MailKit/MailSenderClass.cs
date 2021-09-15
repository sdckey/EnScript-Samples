using System;

// To use the following, install MailKit via NuGet

using MailKit.Net.Smtp;
using MimeKit;

namespace MailSender
{
    static public class MailSenderClass
    {
        static public bool SendMessage(in String from_name,
                                       in String from_email,
                                       in String to_name,
                                       in String to_email,
                                       in String subject,
                                       in String text,
                                       in String host,
                                       Int32 port,
                                       bool use_ssl,
                                       bool use_authentication,
                                       in String user,
                                       in String password,
                                       ref String error_message)
        {
            bool retval = false;
            try
            {
                var mailMessage = new MimeMessage();
                mailMessage.From.Add(new MailboxAddress(from_name, from_email));
                mailMessage.To.Add(new MailboxAddress(to_name, to_email));
                mailMessage.Subject = subject;
                mailMessage.Body = new TextPart("plain")
                {
                    Text = text
                };

                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect(host, port, use_ssl);
                    if (use_authentication)
                    {
                        smtpClient.Authenticate(user, password);
                    }
                    smtpClient.Send(mailMessage);
                    smtpClient.Disconnect(true);
                    retval = true;
                }
            }
            catch (Exception e)
            {
                error_message = e.Message;   
            }
            return retval;
        }
    }
}
