namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// 
    /// </summary>
    public partial class RefTypeTraffic {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public RefTypeTraffic()
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
        public virtual string Vid { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Descr { get; set; }
    }

}
