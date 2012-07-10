using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IE_Cleaner
{
    class IX_Cleanup
    {
        public static void Main()
        {
            Cleaner.ClearFolder(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)));
        }

    }
}
