using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace fileChecker
{
    public class MailClientSender : ISetData<MailMessageComposer>
    {

        private bool fileExists;
        private Params par;
        private ISetData<string> logger;

        public MailClientSender(IGetData<bool> FileChecker, IGetData<Params> ParametersReader, ISetData<string> Logger)
        {
            fileExists = FileChecker.GetData();
            par = ParametersReader.GetData();
            logger = Logger;
        }

        public void SetData(MailMessageComposer param)
        {
            if (!fileExists)
            {
                SmtpClient client = new SmtpClient();
                client.Port = par.MailPort;
                client.Host = par.MailServer;
                //client.EnableSsl = true;
                client.Timeout = 10000;
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(par.MailUser, par.MailPassword);
                try
                {
                    client.Send(param.GetData());
                    logger.SetData("Mail sent - File not found");
                }
                catch (Exception e) {
                    logger.SetData("Error sending mail - " + e.Message);
                }
                
            }
        }
    }
}
