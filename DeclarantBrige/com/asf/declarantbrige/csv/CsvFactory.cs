using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.asf.declarantbrige.csv {
    /// <summary>
    /// Фабрика для преобразования CSV в объекты для загрузки
    /// </summary>
    class CsvFactory {

        public static class RowType
        {
            public static string TURNOVER = "$$$TURNOVER";

            public static string INVOICE = "$$$INVOICE";
        }

    }
}
