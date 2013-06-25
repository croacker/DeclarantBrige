namespace com.asf.declarantbrige.model.proxy {
    class WrkOrgProxy:IHibernateModelProxy
    {
        private WrkOrg wrkOrg;

        public string ModelDescription {
            get { return wrkOrg.OrgName; }
        }

        public WrkOrgProxy(WrkOrg wrkOrg)
        {
            this.wrkOrg = wrkOrg;
        }

        public object Model { get{return wrkOrg;}}
    }
}
