using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace com.asf.util {

    /// <summary>
    /// Общие методы конвертации
    /// </summary>
    static class ConvertUtil {

        public static decimal convertToDecimal(string value)
        {
            return Convert.ToDecimal(value, CultureInfo.InvariantCulture);
        }

    }
}
