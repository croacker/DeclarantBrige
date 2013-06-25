namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Лицензии контрагентов
    /// </summary>
    public partial class WrkContrLicense {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public WrkContrLicense()
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
        public virtual int RefContrId { get; set; }


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
        public virtual int RefLicTypeId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Vidana { get; set; }
    }

}
