namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// There are no comments for com.asf.declarantbrige.model.KLADRRegion, DeclarantBrige in the schema.
    /// </summary>
    public partial class KLADRRegion {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public KLADRRegion()
        {
            OnCreated();
        }


        /// <summary>
        /// There are no comments for CODE in the schema.
        /// </summary>
        public virtual string CODE { get; set; }


        /// <summary>
        /// There are no comments for NAME in the schema.
        /// </summary>
        public virtual string NAME { get; set; }


        /// <summary>
        /// There are no comments for SOCR in the schema.
        /// </summary>
        public virtual string SOCR { get; set; }
    }

}
