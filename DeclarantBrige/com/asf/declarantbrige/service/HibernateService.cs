using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using com.asf.declarantbrige.model;
using log4net;

namespace com.asf.declarantbrige.service {

    /// <summary>
    /// Сервис работы с NHibernate
    /// </summary>
    public class HibernateService:AbstractService
    {
        /// <summary>
        /// Логер
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(HibernateService)); 

        /// <summary>
        /// 
        /// </summary>
        private Configuration configuration;

        /// <summary>
        /// 
        /// </summary>
        private const string CONFIGURATION_FILE = "hibernate.cfg.xml";

        /// <summary>
        /// Ключи конфигурации NHibernate
        /// </summary>
        private static class NHibernateKeys
        {
            public const string CONNECTION_STRING = "connection.connection_string";
        }

        /// <summary>
        /// Кэш Контрагентов
        /// </summary>
        private List<WrkContragent> contragentsCache;
        public List<WrkContragent> ContragentsCache { get { return contragentsCache; } }

        /// <summary>
        /// Кэш алкогольной продукции
        /// </summary>
        private List<RefAlckind> alcoholKindsCache;
        public List<RefAlckind> AlcoholKindsCache { get { return alcoholKindsCache; } }

        private ISessionFactory sessionFactory;

        private ISession currentSession;

        /// <summary>
        /// Соединение с БД установлено
        /// </summary>
        public bool Connected
        {
            get { return sessionFactory != null; }
        }

        protected override void addLogLine(string msg) {
            log.Info(msg);
        }

        public void init()
        {
            getConfiguration();
        }

        private void loadCacheableValues()
        {
            contragentsCache = getContragents();
            alcoholKindsCache = getAlcoholKinds();
        }

        /// <summary>
        /// Получить строку подключения
        /// </summary>
        /// <returns></returns>
        public string HibernateConnectionString
        {
            get
            {
                if (getConfiguration().Properties.ContainsKey(NHibernateKeys.CONNECTION_STRING))
                {
                    return getConfiguration().GetProperty(NHibernateKeys.CONNECTION_STRING);
                }
                else
                {
                    return string.Empty;
                }
            }
            set { getConfiguration().SetProperty(NHibernateKeys.CONNECTION_STRING, value); }
        }

        private Configuration getConfiguration()
        {
            if(configuration == null)
            {
                addLogLine("Load configuration...");
                configuration = new Configuration();
                configuration.Configure(CONFIGURATION_FILE);
            }
            return configuration;
        }

        public bool openConnection()
        {
            getSessionFactory();
            return true;
        }

        public bool closeConnection()
        {
            if (sessionFactory != null)
            {
                sessionFactory.Close();
                sessionFactory.Dispose();
                sessionFactory = null;
            }
            return true;
        }

        private ISessionFactory getSessionFactory() {
            if (sessionFactory == null) {
                addLogLine("Connect to database " + HibernateConnectionString  + "...");
                sessionFactory = getConfiguration().BuildSessionFactory();
                loadCacheableValues();
            }
            return sessionFactory;
        }

        public ISession getSession(bool foreceCreate = false) {
            if (currentSession == null || foreceCreate)
            {
                closeSession(currentSession);
                currentSession = getSessionFactory().OpenSession();
            }
            return currentSession;
        }

        public void closeSession(ISession session)
        {
            if(session != null)
            {
                if (session.IsOpen)
                {
                    session.Close();
                }
            }
        }

        public IQuery getQuery(string que)
        {
            return getSession(true).CreateQuery(que);
        }

        public int executeNoQuery(string que)
        {
            int result = 0;
            var query = getQuery(que);
            using (var transaction = getSession().BeginTransaction()) {
                result = query.ExecuteUpdate();
                transaction.Commit();
            }
            return result;
        }

        public IList<WrkOrg> getOrganizations()
        {
            var query = getQuery("FROM WrkOrg");
            return query.List<WrkOrg>().ToList();
        }

        public IList<WrkOrg> getHeadOrganization() {
            var query = getQuery("FROM WrkOrg WHERE Id = Head_Id");
            return query.List<WrkOrg>().ToList();
        }

        public IList<WrkOrg> getSubstituteDepartments() {
            var query = getQuery("FROM WrkOrg WHERE Id <> Head_Id");
            return query.List<WrkOrg>().ToList();
        }

        public List<DecHeader> getDecHeaders() {
            var query = getQuery("FROM DecHeader");
            return query.List<DecHeader>().ToList();
        }

        /// <summary>
        /// Удалить строки декларации
        /// </summary>
        /// <param name="headerId"></param>
        /// <param name="linesTable"></param>
        public void deleteDeclarationRows(int headerId, string linesTable)
        {
            string que = "DELETE FROM " + linesTable + " WHERE Hid = :headerId";
            var query = getQuery(que);
            query.SetParameter("headerId", headerId);
            using (var transaction = getSession().BeginTransaction()) {
                query.ExecuteUpdate();
                transaction.Commit();
            }
        }

        /// <summary>
        /// Удалить строки декларации
        /// </summary>
        /// <param name="headerId"></param>
        /// <param name="linesTable"></param>
        public void deleteDeclarationRows(int headerId, int idOrganization, string linesTable) {
            string que = "DELETE FROM " + linesTable + " WHERE Hid = :headerId AND idOrg = :idOrganization";
            var query = getQuery(que);
            query.SetParameter("headerId", headerId);
            query.SetParameter("idOrganization", idOrganization);
            using (var transaction = getSession().BeginTransaction()) {
                query.ExecuteUpdate();
                transaction.Commit();
            }
        }

        /// <summary>
        /// Очистить справочник контрагентов
        /// </summary>
        public void deleteAllContragents() {
            string que = "DELETE FROM WrkContragent";
            var query = getQuery(que);
            using (var transaction = getSession().BeginTransaction()) {
                query.ExecuteUpdate();
                transaction.Commit();
            }
        }

        public List<WrkContragent> getContragents() {
            var query = getQuery("FROM WrkContragent");
            return query.List<WrkContragent>().ToList();
        }

        public List<RefAlckind> getAlcoholKinds() {
            var query = getQuery("FROM RefAlckind");
            return query.List<RefAlckind>().ToList();
        }
        
        public void saveOrUpdate(object souObject)
        {
            using (var session = getSession(true))
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(souObject);
                    transaction.Commit();
                }
            }
        }

        public void delete(object deleteObject)
        {
            using (var session = getSession(true))
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(deleteObject);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Найти контрагента по ИНН
        /// </summary>
        /// <param name="inn"></param>
        /// <returns></returns>
        public WrkContragent getContragentByInn(string inn)
        {
            inn = string.IsNullOrEmpty(inn) ? inn : inn.Trim();
            WrkContragent contragent = null;
            var found = ContragentsCache.FindAll(p => p.INN.Trim().Equals(inn));
            if (found.Count != 0) {
                contragent = found[0];
            }
            return contragent;
        }

        /// <summary>
        /// Найти контрагента по ИНН и КПП
        /// </summary>
        /// <param name="inn"></param>
        /// <param name="kpp"></param>
        /// <returns></returns>
        public WrkContragent getContragentByInnKpp(string inn, string kpp) {
            inn = string.IsNullOrEmpty(inn) ? inn : inn.Trim();
            kpp = string.IsNullOrEmpty(kpp) ? kpp : kpp.Trim();
            WrkContragent contragent = null;
            var found = ContragentsCache.FindAll(p => (p.INN.Trim().Equals(inn)
                && p.KPP.Equals(kpp)));
            if (found.Count != 0) {
                contragent = found[0];
            }
            return contragent;
        }

        /// <summary>
        /// Найти контрагента по Наименованию
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public WrkContragent getContragentByName(string name) {
            name = string.IsNullOrEmpty(name) ? name : name.Trim();
            WrkContragent contragent = null;
            var found = ContragentsCache.FindAll(p => p.OrgName.Equals(name));
            if (found.Count != 0) {
                contragent = found[0];
            }
            return contragent;
        }

        /// <summary>
        /// Получить лицензию для контрагента, первую
        /// </summary>
        /// <param name="contragentId"></param>
        /// <returns></returns>
        public WrkContrLicense getContragentLicenseByContragentId(int contragentId)
        {
            WrkContrLicense contrLicense = null;
            string que = "FROM WrkContrLicense WHERE RefContrId = :contragentId";
            var query = getQuery(que);
            query.SetParameter("contragentId", contragentId);

            foreach (var license in query.List<WrkContrLicense>().ToList())
            {
                contrLicense = license;
                break;
            }

            return contrLicense;
        }

        public RefAlckind getAlcoholByCode(string code) {
            RefAlckind alcoholKind = null;
            var found = AlcoholKindsCache.FindAll(p => p.Code.Equals(code));
            if (found.Count != 0) {
                alcoholKind = found[0];
            }
            return alcoholKind;
        }
    }
}
