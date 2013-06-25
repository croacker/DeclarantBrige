using com.asf.declarantbrige.service;

namespace com.asf.declarantbrige {

    /// <summary>
    /// Контекст исполнения
    /// </summary>
    public abstract class AbstractContext
    {
        public HibernateService Hibernate;

        public AbstractContext(HibernateService hibernateService)
        {
            Hibernate = hibernateService;
        }

    }
}
