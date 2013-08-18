using System.IO;
using System.Text;
using com.asf.declarantbrige.csv;
using com.asf.declarantbrige.service;

namespace DeclarantBrige.com.asf.declarantbrige.service.csv {

    /// <summary>
    /// Сервис работы с CSV файлами обмена
    /// </summary>
    class CsvService: AbstractService {

        /// <summary>
        /// Виды файлов
        /// </summary>
        public static class CsvFiles {
            public const string CONTRAGENT = "kontr.csv";
            public const string DECLARATION_11 = "11.csv";
            public const string DECLARATION_12 = "12.csv";
        }

        /// <summary>
        /// Прочитать декларацию 11
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        public Declaration11Csv getDeclaration11(string folderName)
        {
            Declaration11Csv declaration11 = new Declaration11Csv();

            if(File.Exists(folderName + CsvFiles.DECLARATION_11))
            {
                using (TextReader textReader = new StreamReader(folderName + CsvFiles.DECLARATION_11, Encoding.Default))
                {
                    string str = textReader.ReadLine();
                    while (str != null)
                    {
                        string[] strLine = str.Split(';');
                        if (strLine[0].Equals("$$$TURNOVER"))
                        {
                            declaration11.addTurnover(new Turnover11Csv(strLine));
                        } else if (strLine[0].Equals("$$$INVOICE"))
                        {
                            declaration11.addInvoice(new InvoiceCsv(strLine));
                        }

                        str = textReader.ReadLine();
                    }
                }
            }

            return declaration11;
        }

        /// <summary>
        /// Прочитать декларацию 12
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        public Declaration12Csv getDeclaration12(string folderName) {
            Declaration12Csv declaration12 = new Declaration12Csv();

            if (File.Exists(folderName + CsvFiles.DECLARATION_11)) {
                using (TextReader textReader = new StreamReader(folderName + CsvFiles.DECLARATION_12, Encoding.Default)) {
                    string str = textReader.ReadLine();
                    while (str != null) {
                        string[] strLine = str.Split(';');
                        if (strLine[0].Equals("$$$TURNOVER")) {
                            declaration12.addTurnover(new Turnover12Csv(strLine));
                        } else if (strLine[0].Equals("$$$INVOICE")) {
                            declaration12.addInvoice(new InvoiceCsv(strLine));
                        }

                        str = textReader.ReadLine();
                    }
                }
            }

            return declaration12;
        }

    }
}
