namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// 
    /// </summary>
    public partial class TempT {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public TempT()
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
        public virtual string Ttype { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? Tload { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Tnum { get; set; }
    }

}
