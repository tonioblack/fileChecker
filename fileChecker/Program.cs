using System;
using System.Collections.Generic;
using System.Text;

namespace fileChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new FileWriter();
            var paramsReader = new ParamsReader(args, logger);
            var fileChecker = new FileChecker(paramsReader);
            var mailComposer = new MailMessageComposer(paramsReader);
            var mailSender = new MailClientSender(fileChecker, paramsReader, logger);
            mailSender.SetData(mailComposer);
            //Console.ReadLine();
        }
    }
}
