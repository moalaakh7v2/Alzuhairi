using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class RAR
    {
        public void UnZip(string zipPath)
        {
            ZipFile.ExtractToDirectory(zipPath, "Uploads/");
        }
    }
}
