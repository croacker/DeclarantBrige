namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// There are no comments for com.asf.declarantbrige.model.RefDeclPeriod, DeclarantBrige in the schema.
    /// </summary>
    public partial class RefDeclPeriod {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public RefDeclPeriod()
        {
            OnCreated();
        }


        /// <summary>
        /// There are no comments for Code in the schema.
        /// </summary>
        public virtual string Code { get; set; }


        /// <summary>
        /// There are no comments for Descr in the schema.
        /// </summary>
        public virtual string Descr { get; set; }
    }

}
