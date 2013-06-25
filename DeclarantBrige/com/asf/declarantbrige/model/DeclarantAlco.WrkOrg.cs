namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Организация и подразделения
    /// </summary>
    public partial class WrkOrg{
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public WrkOrg()
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
        public virtual string INN { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string KPP { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string OrgName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Phone { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Email { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string CCode { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Index { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Rcode { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Area { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string City { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Place { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Street { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Building { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Korp { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Flat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? HeadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? OrgType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? DirID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? BuhID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Liter { get; set; }
    }

}
