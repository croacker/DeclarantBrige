using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using com.asf.util;

namespace com.asf.declarantbrige.csv {
    
    /// <summary>
    /// Обороты
    /// </summary>
    abstract class TurnoverCsv {

        /// <summary>
        /// Код алкоголя
        /// </summary>
        public string VidCode { get; set; }

        /// <summary>
        /// ИД организации/подразделения
        /// </summary>
        public int IdOrg { get; set; }
        
        /// <summary>
        /// ИД производителя
        /// </summary>
        public string ProdInn { get; set; }

        /// <summary>
        /// ИД производителя
        /// </summary>
        public string ProdKpp { get; set; }

        /// <summary>
        /// ИД производителя
        /// </summary>
        public string ProdName { get; set; }

        /// <summary>
        /// Остаток на начало
        /// </summary>
        public decimal P106 { get; set; }

        /// <summary>
        /// Поступление от производителя
        /// </summary>
        public decimal P107 { get; set; }

        /// <summary>
        /// Поступление от оптовика
        /// </summary>
        public decimal P108 { get; set; }

        /// <summary>
        /// Поступление по импорту
        /// </summary>
        public decimal P109 { get; set; }

        /// <summary>
        /// Закупки итого
        /// </summary>
        public decimal P110 { get; set; }

        /// <summary>
        /// Возврат от покупателя
        /// </summary>
        public decimal P111 { get; set; }

        /// <summary>
        /// Прочее поступление
        /// </summary>
        public decimal P112 { get; set; }

        public TurnoverCsv(string[] atr)
        {
            VidCode = atr[1];
            ProdInn = atr[2];
            ProdKpp = atr[3];
            ProdName = atr[4];
            P106 = ConvertUtil.convertToDecimal(atr[5]);
            P107 = 0;
            P108 = ConvertUtil.convertToDecimal(atr[6]);
            P109 = 0;
            P110 = P108;
            P111 = 0;
            P112 = ConvertUtil.convertToDecimal(atr[7]);
        }
    }

    /// <summary>
    /// Поступления
    /// </summary>
    class InvoiceCsv
    {
        /// <summary>
        /// Код алкоголя
        /// </summary>
        public string VidCode { get; set; }

        /// <summary>
        /// ИД производителя
        /// </summary>
        public string ProdInn { get; set; }

        /// <summary>
        /// ИД производителя
        /// </summary>
        public string ProdKpp { get; set; }

        /// <summary>
        /// ИД производителя
        /// </summary>
        public string ProdName { get; set; }

        /// <summary>
        /// ИНН поставщика
        /// </summary>
        public string SupplierInn { get; set; }

        /// <summary>
        /// КПП поставщика
        /// </summary>
        public string SupplierKpp { get; set; }

        /// <summary>
        /// Наименование поставщика
        /// </summary>
        public string SupplierName { get; set; }

        /// <summary>
        /// Дата ТТН
        /// </summary>
        public string P29 { get; set; }

        /// <summary>
        /// Номер ТТН
        /// </summary>
        public string P210 { get; set; }

        /// <summary>
        /// Номер ГТД
        /// </summary>
        public string P211 { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public decimal P212 { get; set; }

        public InvoiceCsv(string[] atr)
        {
            VidCode = atr[1];
            ProdInn = atr[2];
            ProdKpp = atr[3];
            ProdName = atr[4];
            SupplierInn = atr[5];
            SupplierKpp = atr[6];
            SupplierName = atr[7];
            P29 = atr[8];
            P210 = atr[9];
            P211 = atr[10];
            P212 = ConvertUtil.convertToDecimal(atr[11]);
        }
    }
}
