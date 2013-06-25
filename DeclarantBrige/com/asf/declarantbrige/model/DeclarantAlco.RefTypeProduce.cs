namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// 
    /// </summary>
    public partial class RefTypeProduce {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public RefTypeProduce()
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
