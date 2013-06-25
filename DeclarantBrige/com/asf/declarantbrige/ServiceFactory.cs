using System;
using System.Collections.Generic;
using com.asf.declarantbrige.service;
using NHibernate;
using Spring.Context;
using com.asf.declarantbrige.service;

namespace com.asf.declarantbrige {

    /// <summary>
    /// Фабрика сервисов
    /// </summary>
    class ServiceFactory:AbstractFactory
    {
        public static ServiceFactory getInstance()
        {
            if(instance == null)
            {
                instance = new ServiceFactory();
            }
            return (ServiceFactory) instance;
        }

        public AbstractService getService(Type type)
        {
            AbstractService service = getService(type.Name);
            service.CtrlLogger = CtrlLogger;
            return service;
        }

        public AbstractService getService(String name)
        {
            if (!getApplicationContext().ContainsObjectDefinition(name)) {
                throw new WrongClassException("Не найдено объявление сервиса " + name, name, name);
            }
            return (AbstractService)getApplicationContext().GetObject(name);
        }

        #region CONCRETE_SERVICES
        public ConfigurationService ConfigurationService
        {
            get { return (ConfigurationService) getService(typeof (ConfigurationService)); }
        }

        public HibernateService HibernateService
        {
            get{return (HibernateService)getService(typeof(HibernateService));}
        }

        public ProcessingService ProcessingService
        {
            get { return (ProcessingService) getService(typeof (ProcessingService)); }
        }

        public SqlService SqlService
        {
            get { return (SqlService) getService(typeof (SqlService)); }
        }

        public XmlService XmlService
        {
            get { return (XmlService) getService(typeof (XmlService)); }
        }
        
        public BackUpService BackUpService
        {
            get { return (BackUpService) getService(typeof (BackUpService)); }
        }

        public CsvService CsvService
        {
            get { return (CsvService) getService(typeof (CsvService)); }
        }

        public CheckService CheckService {
            get { return (CheckService)getService(typeof(CheckService)); }
        }
        #endregion
    }
}
