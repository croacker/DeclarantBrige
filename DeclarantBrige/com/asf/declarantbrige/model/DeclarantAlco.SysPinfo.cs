namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// 
    /// </summary>
    public partial class SysPinfo {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public SysPinfo()
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
        public virtual int InfoCode { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string InfoValue { get; set; }
    }

}
