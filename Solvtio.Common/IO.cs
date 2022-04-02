using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Solvtio.Common
{
    public static class IO
    {
        
        public static void CreateDirectoryIfNotExist(string fulPath)
        {
            if (Directory.Exists(fulPath)) return;
            
            Directory.CreateDirectory(fulPath);
        }

    }
}
