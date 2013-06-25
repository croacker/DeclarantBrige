namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// 
    /// </summary>
    public partial class Proxy {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public Proxy()
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
        public virtual int Exist { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Http { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual int Port { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Password { get; set; }
    }

}
