﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace fileChecker
{
    public class MailMessageComposer : IGetData<MailMessage>
    {
        private Params par;
        public MailMessageComposer(IGetData<Params> ParameterReader)
        {
            par = ParameterReader.GetData();
        }
        public MailMessage GetData()
        {
            MailMessage message = new MailMessage(par.MailFrom, par.MailTo);
            message.Subject = "FILE MISSING";
            message.Body = @"This message is generated by FileChecker daemon: the file you're watching does not exists anymore!";
            return message;
        }
    }
}
