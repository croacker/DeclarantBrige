namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// There are no comments for com.asf.declarantbrige.model.RefFotch, DeclarantBrige in the schema.
    /// </summary>
    public partial class RefFotch {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public RefFotch()
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
