namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Организация 
    /// возможно они хотели многофирменного учета
    /// сей час не используется
    /// </summary>
    public partial class WrkOrganization {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public WrkOrganization()
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
        public virtual string FullName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string ShortName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string INN { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string KPP { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string OGRN { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string OKATO { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Phone { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Addres { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual int? HeadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int OrgType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? DirID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? BuhID { get; set; }
    }

}
