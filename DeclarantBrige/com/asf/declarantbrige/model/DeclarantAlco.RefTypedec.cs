namespace com.asf.declarantbrige.model
{

    /// <summary>
    ///
    /// </summary>
    public partial class RefTypedec {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public RefTypedec()
        {
            OnCreated();
        }


        /// <summary>
        ///
        /// </summary>
        public virtual string Code { get; set; }


        /// <summary>
        ///
        /// </summary>
        public virtual string Data { get; set; }
    }

}
