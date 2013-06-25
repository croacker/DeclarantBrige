namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// 
    /// </summary>
    public partial class TempContr8 {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public TempContr8()
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
        public virtual string Inn { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Kpp { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Oname { get; set; }
    }

}
