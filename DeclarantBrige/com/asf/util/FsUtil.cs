using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.asf.util {

    /// <summary>
    /// Общие методы работы с ФС
    /// </summary>
    static class FsUtil {

        public static string includeTrailingBackslash(string path)
        {
            path = path.Trim();
            if(!string.IsNullOrEmpty(path) &&
                !path.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()))
            {
                path += System.IO.Path.DirectorySeparatorChar.ToString();
            }
            return path;
        }

    }
}
