using System.Collections.Generic;

namespace com.asf.configuration {

    /// <summary>
    /// Абстрактный предок для конфигураций
    /// </summary>
    public abstract class AbstractConfiguration
    {
        public abstract string getName();

        /// <summary>
        /// Параметры конфигурации
        /// </summary>
        protected Dictionary<string, object> configurationData = new Dictionary<string, object>();

        public abstract void init();

        public abstract void save();

        /// <summary>
        /// Получить значение параметра
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object getProperty(string key)
        {
            if (configurationData.ContainsKey(key)) {
                return configurationData[key];
            }
            return null;
        }

        /// <summary>
        /// Установить значение параметра
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public void setProperty(string key, object value) {
            if(configurationData.ContainsKey(key))
            {
                configurationData[key] = value;
            }
            else
            {
                configurationData.Add(key, value);
            }
        }

        /// <summary>
        /// Получить значение параметра как строку
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string getString(string key)
        {
            object value = getProperty(key);
            if(value != null)
            {
                return getProperty(key).ToString();
            }
            return string.Empty;
        }
        
    }
}
