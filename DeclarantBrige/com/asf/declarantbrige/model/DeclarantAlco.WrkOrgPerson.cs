namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Со-трудники
    /// </summary>
    public partial class WrkOrgPerson {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public WrkOrgPerson()
        {
            OnCreated();
        }


        /// <summary>
        /// 
        /// </summary>
        public virtual int Id { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Surname { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string SecName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string INN { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Phone { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual int? RefDocTypeId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string DocNumber { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string DocVidan { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string DocDate { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdCCode { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdIndex { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdRCode { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdArea { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdCity { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdPlace { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdStreet { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdHouse { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdBuilding { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string AdFlat { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual int Type { get; set; }
    }

}
