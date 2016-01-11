using System;
using System.Collections.Generic;
using System.Text;

namespace fileChecker
{
    public class Params
    {
        public static  string FILE_SWITCH = "-i";
        public static  string MAIL_TO_SWITCH = "-t";
        public static  string MAIL_FROM_SWITCH = "-f";
        public static  string MAIL_SERVER_SWITCH = "-s";
        public static  string MAIL_USER_SWITCH = "-u";
        public static  string MAIL_PASSWORD_SWITCH = "-p";
        public static string MAIL_PORT_SWITCH = "-o";

        public string FilePath { get; set; }

        public string MailTo { get; set; }

        public string MailFrom { get; set; }

        public string MailServer { get; set; }

        public string MailUser { get; set; }

        public string MailPassword { get; set; }

        public int MailPort { get; set; }

    }
}
