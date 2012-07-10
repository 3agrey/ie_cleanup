using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IE_Cleaner
{
    class Cleaner
    {
        public static void ClearFolder(DirectoryInfo Path)
        {
            foreach (FileInfo File in Path.GetFiles())
            {
                try
                {
                    File.Delete();

                }
                catch (Exception)
                {
                }
            }
            foreach (DirectoryInfo Folder in Path.GetDirectories())
            {
                ClearFolder(Folder);
            }
        }
    }
}