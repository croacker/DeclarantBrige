using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.asf.util;

namespace com.asf.declarantbrige.csv {

    /// <summary>
    /// Обертка для декларации 12 из CSV
    /// </summary>
    class Declaration12Csv {
        public List<Turnover12Csv> Turnovers12 { get; set; }

        public List<InvoiceCsv> Invoices { get; set; }

        public Declaration12Csv() {
            Turnovers12 = new List<Turnover12Csv>();
            Invoices = new List<InvoiceCsv>();
        }

        public void addTurnover(Turnover12Csv turnover) {
            Turnovers12.Add(turnover);
        }

        public void addInvoice(InvoiceCsv invoice) {
            Invoices.Add(invoice);
        }

    }

    class Turnover12Csv : TurnoverCsv {

        /// <summary>
        /// Поступление всего
        /// </summary>
        public decimal P113 { get; set; }

        /// <summary>
        /// Расход продажи 
        /// </summary>
        public decimal P114 { get; set; }

        /// <summary>
        /// Прочий расход
        /// </summary>
        public decimal P115 { get; set; }

        /// <summary>
        /// Возврат поставщику
        /// </summary>
        public decimal P116 { get; set; }

        /// <summary>
        /// Расход всего
        /// </summary>
        public decimal P117 { get; set; }

        /// <summary>
        /// Остаток на конец
        /// </summary>
        public decimal P118 { get; set; }

        public Turnover12Csv(string[] atr)
            : base(atr) {
            P113 = ConvertUtil.convertToDecimal(atr[8]);
            P114 = ConvertUtil.convertToDecimal(atr[9]);
            P115 = ConvertUtil.convertToDecimal(atr[10]);
            P116 = 0;
            P117 = ConvertUtil.convertToDecimal(atr[11]);
            P118 = ConvertUtil.convertToDecimal(atr[12]);
        }
    }

    /// <summary>
    /// Поступления
    /// </summary>
    class Invoice12Csv : InvoiceCsv {
        public Invoice12Csv(string[] atr)
            : base(atr) {
        }
    }

}
