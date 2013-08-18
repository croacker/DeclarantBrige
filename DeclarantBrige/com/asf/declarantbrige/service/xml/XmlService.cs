using System.IO;
using System.Xml.Serialization;
using com.asf.declarantbrige.service;
using declarant.xml;

namespace DeclarantBrige.com.asf.declarantbrige.service.xml {

    /// <summary>
    /// Сервис для работы с XML-сериализацией
    /// </summary>
    internal class XmlService : AbstractService
    {
        private Справочники referencesCache;

        public static class XmlFiles
        {
            public const string CONTRAGENT = "kontr.xml";
            public const string DECLARATION_11 = "11.xml";
            public const string DECLARATION_12 = "12.xml";
        }

        public Справочники getReferences(string folderName)
        {
            string fileName = folderName + XmlFiles.CONTRAGENT;

            Справочники references = null;
            if (File.Exists(fileName))
            {
                using (var stream = new FileStream(fileName, FileMode.Open))
                {
                    var serializer = new XmlSerializer(typeof (Справочники));
                    references = (Справочники) serializer.Deserialize(stream);
                }
            }
            return references;
        }

        public declarant.xml11.Файл getDeclaration11(string folderName)
        {

            string fileName = folderName + XmlFiles.DECLARATION_11;

            declarant.xml11.Файл declaration;
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof (declarant.xml11.Файл));
                declaration = (declarant.xml11.Файл) serializer.Deserialize(stream);
            }

            referencesCache = getReferences(folderName);

            return declaration;
        }

        public declarant.xml12.Файл getDeclaration12(string folderName)
        {
            string fileName = folderName + XmlFiles.DECLARATION_12;

            declarant.xml12.Файл declaration;
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof (declarant.xml12.Файл));
                declaration = (declarant.xml12.Файл) serializer.Deserialize(stream);
            }

            referencesCache = getReferences(folderName);

            return declaration;
        }

        public object findContragentByInn(string inn)
        {
            return null;
        }

        public object findContragentByName(string name) {
            return null;
        }

    }
}
