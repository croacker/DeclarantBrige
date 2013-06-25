using System.IO;
using com.asf.declarantbrige.model;
using com.asf.declarantbrige.service;

namespace com.asf.declarantbrige.processing {

    /// <summary>
    /// Фабрика объектов обработки
    /// </summary>
    class ProcessingFactory
    {
        private static ProcessingFactory instance;

        public static ProcessingFactory getInstance()
        {
            if(instance == null)
            {
                instance = new ProcessingFactory();
            }
            return instance;
        }

        private ProcessingFactory()
        {
            
        }

        /// <summary>
        /// Получить обхект обработки для модели
        /// </summary>
        /// <param name="decHeader"></param>
        /// <param name="wrkOrg"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public IProcessingHandler getHandler(DecHeader decHeader, WrkOrg wrkOrg, AbstractContext context)
        {
            IDeclarationHandler processingHandler = null;
            string exchangeFolder =
                ServiceFactory.getInstance().ConfigurationService.getAppConfiguration().getExchangePath();

            if(decHeader.TypeId.Equals(1))
            {
                if(File.Exists(exchangeFolder + XmlService.XmlFiles.DECLARATION_11))
                {
                    processingHandler = new Declaration11HandlerXml();
                }if(File.Exists(exchangeFolder + CsvService.CsvFiles.DECLARATION_11))
                {
                    processingHandler = new Declaration11HandlerCsv();
                }
            }
            else
            {
                if(File.Exists(exchangeFolder + XmlService.XmlFiles.DECLARATION_12))
                {
                    processingHandler = new Declaration12HandlerXml();
                }if(File.Exists(exchangeFolder + CsvService.CsvFiles.DECLARATION_12))
                {
                    processingHandler = new Declaration12HandlerCsv();
                }
            }

            if(processingHandler != null)
            {
                processingHandler.context = context;
                processingHandler.DeclarationHeader = decHeader;
                processingHandler.Organization = wrkOrg;
            }

            return processingHandler;
        }
    }

    /// <summary>
    /// Тип файла обработки
    /// </summary>
    public enum DeclarationFileType
    {
        XML,
        CSV
    }
}
