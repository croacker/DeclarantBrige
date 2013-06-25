using System.Collections.Generic;
using System.Windows.Forms;
using com.asf.configuration;

namespace com.asf.declarantbrige.configuration {

    /// <summary>
    /// Конфигурация приложения
    /// </summary>
    public class AppConfiguration :AbstractConfiguration
    {
        public override string getName()
        {
            return "AppConfiguration";
        }

        /// <summary>
        /// Имена параметров конфигурации
        /// </summary>
        public static class Properties
        {
            /// <summary>
            /// Путь к каталогу обмена
            /// </summary>
            public static string EXCHANGE_PATH = "exchangePath";

            /// <summary>
            /// Каталог Декларант-Алко
            /// </summary>
            public static string DECLARANT_FOLDER = "declarantFolder";
        }

        public AppConfiguration()
        {
            init();
        }

        public override void init()
        {
            setProperty(Properties.EXCHANGE_PATH, getFromRegistry(Properties.EXCHANGE_PATH));
            setProperty(Properties.DECLARANT_FOLDER, getFromRegistry(Properties.DECLARANT_FOLDER));
        }

        public override void save()
        {
            foreach (var parameter in configurationData)
            {
                if (parameter.Value is string){
                    setToRegistry(parameter.Key, parameter.Value.ToString());
                }
            }
        }

        #region REGISTRY
        /// <summary>
        /// Получить значение из реестра
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private string getFromRegistry(string key)
        {
            object value = Application.UserAppDataRegistry.GetValue(key);
            if(value != null)
            {
                return value.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Записать значение в реестр
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void setToRegistry(string key, string value) {
            Application.UserAppDataRegistry.SetValue(key, value);
        }
        #endregion

        public string getExchangePath()
        {
            return getString(Properties.EXCHANGE_PATH);
        }

        public void setExchangePath(string value) {
            setProperty(Properties.EXCHANGE_PATH, value);
        }

        public string getDeclarantFolder() {
            return getString(Properties.DECLARANT_FOLDER);
        }

        public void setDeclarantFolder(string value) {
            setProperty(Properties.DECLARANT_FOLDER, value);
        }

    }
}
