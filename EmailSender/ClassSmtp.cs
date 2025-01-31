using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace EmailSender
{
    class ClassSmtp
    {
        public string mServer = "";
        public string mPort = "";
        public string mUserName = "";
        public string mPassword = "";
        public void Send(string strFrom, string strTo, string strSubject, string strBody, bool isHtml)
        {
            string strData;
            DateTime dtmStart;
            System.Net.Mail.MailMessage eMail = new System.Net.Mail.MailMessage();
            eMail.IsBodyHtml = isHtml;
            eMail.From = strFrom;
            eMail.To = strTo;
            eMail.Body = strBody;
            eMail.Subject = strSubject;
            
            SmtpClient client = new SmtpClient(mServer, mPort);
            if ((mUserName != "") || (mPassword != ""))
            {
                client.
            }

            client.SendAsync(eMail);
            
            eMail.Dispose();
        }
    }
}
