namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// 
    /// </summary>
    public partial class RefLicType {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public RefLicType()
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
        public virtual string Code { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Descr { get; set; }
    }

}
