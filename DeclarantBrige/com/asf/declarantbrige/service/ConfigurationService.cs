using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.asf.configuration;
using com.asf.declarantbrige.configuration;

namespace com.asf.declarantbrige.service {

    /// <summary>
    /// Сервис работы с конфигурациями
    /// </summary>
    class ConfigurationService:AbstractService  {

        /// <summary>
        /// Список конфигураций
        /// </summary>
        private Dictionary<Type, AbstractConfiguration> configurations = new Dictionary<Type, AbstractConfiguration>();

        public ConfigurationService()
        {
            configurations.Add(typeof(AppConfiguration), new AppConfiguration());
            configurations.Add(typeof(DeclarantConfiguration), new DeclarantConfiguration());
        }

        /// <summary>
        /// Создать объект конфигурации
        /// </summary>
        /// <param name="typee"></param>
        private void createConfiguration(Type typee)
        {
            configurations.Add(typee, (AbstractConfiguration) Activator.CreateInstance(typee));
        }

        /// <summary>
        /// Получить объект конфигурации
        /// </summary>
        /// <param name="typee"></param>
        public AbstractConfiguration getConfiguration(Type typee)
        {
            if(!configurations.ContainsKey(typee))
            {
                createConfiguration(typee);
            }
            return configurations[typee];
        }

        /// <summary>
        /// Получить конфигурацию приложения
        /// </summary>
        /// <param name="typee"></param>
        public AppConfiguration getAppConfiguration()
        {
            return (AppConfiguration)getConfiguration(typeof(AppConfiguration));
        }

        /// <summary>
        /// Получить конфигурацию Декларанта
        /// </summary>
        /// <param name="typee"></param>
        public DeclarantConfiguration getDeclarantConfiguration() {
            return (DeclarantConfiguration)getConfiguration(typeof(DeclarantConfiguration));
        }

        /// <summary>
        /// Вызвать сохранение конфигурации
        /// </summary>
        public void callSave()
        {
            foreach (var abstractConfiguration in configurations)
            {
                abstractConfiguration.Value.save();
            }
        }

    }
}
