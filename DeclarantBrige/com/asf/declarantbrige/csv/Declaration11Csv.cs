using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.asf.util;

namespace com.asf.declarantbrige.csv {

    /// <summary>
    /// Обертка для декларации 11 из CSV
    /// </summary>
    class Declaration11Csv
    {
        public List<Turnover11Csv> Turnovers11 { get; set; }

        public List<InvoiceCsv> Invoices { get; set; }

        public Declaration11Csv()
        {
            Turnovers11 = new List<Turnover11Csv>();
            Invoices = new List<InvoiceCsv>();
        }

        public void addTurnover(Turnover11Csv turnover)
        {
            Turnovers11.Add(turnover);
        }

        public void addInvoice(InvoiceCsv invoice) {
            Invoices.Add(invoice);
        }
    }

    class Turnover11Csv : TurnoverCsv {

        /// <summary>
        /// Перемещение
        /// </summary>
        public decimal P113 { get; set; }

        /// <summary>
        /// Поступление всего
        /// </summary>
        public decimal P114 { get; set; }

        /// <summary>
        /// Расход продажи
        /// </summary>
        public decimal P115 { get; set; }

        /// <summary>
        /// Прочий расход
        /// </summary>
        public decimal P116 { get; set; }

        /// <summary>
        /// Возврат поставщику
        /// </summary>
        public decimal P117 { get; set; }

        /// <summary>
        /// Расход перемещение
        /// </summary>
        public decimal P118 { get; set; }

        /// <summary>
        /// Расход всего
        /// </summary>
        public decimal P119 { get; set; }

        /// <summary>
        /// Остаток на конец
        /// </summary>
        public decimal P120 { get; set; }

        public Turnover11Csv(string[] atr) : base(atr)
        {
            P113 = 0;
            P114 = ConvertUtil.convertToDecimal(atr[8]);
            P115 = ConvertUtil.convertToDecimal(atr[9]);
            P116 = ConvertUtil.convertToDecimal(atr[10]);
            P117 = 0;
            P118 = 0;
            P119 = ConvertUtil.convertToDecimal(atr[11]);
            P120 = ConvertUtil.convertToDecimal(atr[12]);
        }
    }

    class Invoice11Csv:InvoiceCsv
    {
        public Invoice11Csv(string[] atr) : base(atr)
        {
        }
    }
}
