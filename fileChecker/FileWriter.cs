using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace fileChecker
{
   public  class FileWriter: ISetData<string>
    {
        public void SetData(string param)
        {
           string path = AppDomain.CurrentDomain.BaseDirectory + "\\logs.txt";
            using(StreamWriter s = new StreamWriter(path, true)) {
                s.WriteLine(" - " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ": " + param);
            }
        }
    }
}
