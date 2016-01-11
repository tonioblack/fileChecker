using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace fileChecker
{
    public class FileChecker: IGetData<bool>
    {
        private Params par;

        public FileChecker(IGetData<Params> ParamsReader)
        {
            par = ParamsReader.GetData();
        }
        public bool GetData()
        {
            return File.Exists(par.FilePath);
        }
    }
}
