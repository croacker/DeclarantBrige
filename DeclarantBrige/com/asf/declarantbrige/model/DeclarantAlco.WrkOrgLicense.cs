namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Лицензии организации
    /// </summary>
    public partial class WrkOrgLicense {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public WrkOrgLicense()
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
        public virtual int RefOrgId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Series { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Number { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string DateBegin { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string DateEnd { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual int? RefLicTypeId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Vidana { get; set; }
    }

}
