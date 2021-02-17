using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XFORCE
{
    class Functions
    {
        public static void ListBox(ListBox lsb, string Folder, string FileType) 
        { 
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType); foreach (FileInfo file in Files) 
            { 
                lsb.Items.Add(file.Name);
            } 
        }
    }
}

