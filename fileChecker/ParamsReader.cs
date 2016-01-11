using System;
using System.Collections.Generic;
using System.Text;

namespace fileChecker
{
   public  class ParamsReader: IGetData<Params>
    {

       private string[] args;
       private ISetData<string> logger;

       public ParamsReader(string[] Args, ISetData<string> Logger)
       {
           args = Args;
       }

        public Params GetData()
        {
            Params ret = new Params();
            var lArgs = args.ToList();
            try
            {
                ret.FilePath = lArgs.ElementAt(lArgs.IndexOf(Params.FILE_SWITCH) + 1);
                ret.MailTo = lArgs.ElementAt(lArgs.IndexOf(Params.MAIL_TO_SWITCH) + 1);
                ret.MailFrom = lArgs.ElementAt(lArgs.IndexOf(Params.MAIL_FROM_SWITCH) + 1);
                ret.MailServer = lArgs.ElementAt(lArgs.IndexOf(Params.MAIL_SERVER_SWITCH) + 1);
                ret.MailUser = lArgs.ElementAt(lArgs.IndexOf(Params.MAIL_USER_SWITCH) + 1);
                ret.MailPassword = lArgs.ElementAt(lArgs.IndexOf(Params.MAIL_PASSWORD_SWITCH) + 1);
                if (Convert.ToInt16(lArgs.ElementAt(lArgs.IndexOf(Params.MAIL_PORT_SWITCH) + 1)) == 0)
                {
                    ret.MailPort = 25;
                }
                else
                {
                    ret.MailPort = Convert.ToInt16(lArgs.ElementAt(lArgs.IndexOf(Params.MAIL_PORT_SWITCH) + 1));
                }
                
            }
            catch (Exception e)
            {
                logger.SetData("Wrong parameters  - " + e.Message);
            }
            return ret;
        }
    }
}
