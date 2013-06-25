using Common.Logging;
using com.asf.component;
using com.asf.declarantbrige.model;

namespace com.asf.declarantbrige.processing {

    /// <summary>
    /// Обработчик декларации 
    /// </summary>
    abstract class DeclarationHandler : IDeclarationHandler {

        /// <summary>
        /// Контрол для вывода лога
        /// </summary>
        public ICtrlLogger CtrlLogger { get; set; }

        private static readonly ILog log = LogManager.GetLogger(typeof(DeclarationHandler));

        public AbstractContext context { get; set; }

        public DecHeader DeclarationHeader { get; set; }

        public WrkOrg Organization { get; set; }

        public bool DeletePrevious { get; set; }

        public virtual void handle() {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Вывод сообщения в лог
        /// </summary>
        /// <param name="msg"></param>
        protected virtual void addLogLine(string msg) {
            if (CtrlLogger != null) {
                CtrlLogger.addLogLine(msg);
            }
            if(log != null)
            {
                log.Info(msg);
            }
        }

        /// <summary>
        /// Очистить декларацию(удалить строки)
        /// </summary>
        /// <param name="?"></param>
        protected void deleteDeclarationRows(DecHeader decHeader, WrkOrg organization, string linesTable) {
            ServiceFactory.getInstance().HibernateService.deleteDeclarationRows(decHeader.Id, organization.Id, linesTable);
        }

        /// <summary>
        /// Найти контрагента в кэше
        /// </summary>
        /// <returns></returns>
        protected WrkContragent getContragentByInn(string inn) {
            return ServiceFactory.getInstance().HibernateService.getContragentByInn(inn);
        }

        /// <summary>
        /// Найти контрагента в кэше
        /// </summary>
        /// <returns></returns>
        protected WrkContragent getContragentByInnKpp(string inn, string kpp) {
            return ServiceFactory.getInstance().HibernateService.getContragentByInnKpp(inn, kpp);
        }

        /// <summary>
        /// Найти контрагента в кэше
        /// </summary>
        /// <returns></returns>
        protected WrkContragent getContragentByName(string name) {
            return ServiceFactory.getInstance().HibernateService.getContragentByName(name);
        }
    }
}
