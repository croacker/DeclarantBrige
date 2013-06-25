namespace com.asf.declarantbrige.model
{
    /// <summary>
    /// Строка декларации 12
    /// </summary>
    public partial class DecF12 {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public DecF12()
        {
            OnCreated();
        }

        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual int Id { get; set; }


        /// <summary>
        /// There are no comments for Hid in the schema.
        /// </summary>
        public virtual int? Hid { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        //public virtual DecHeader Header { get; set; }

        /// <summary>
        /// There are no comments for VidCode in the schema.
        /// </summary>
        public virtual string VidCode { get; set; }

        /// <summary>
        /// Вид алкогольной продукции
        /// </summary>
        //public virtual RefAlckind AlkoholKind { get; set; }

        /// <summary>
        /// There are no comments for ProdId in the schema.
        /// </summary>
        public virtual int? ProdId { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        //public virtual WrkContragent Producer { get; set; }

        /// <summary>
        /// There are no comments for IdPost in the schema.
        /// </summary>
        public virtual int? IdPost { get; set; }


        /// <summary>
        /// There are no comments for P29 in the schema.
        /// </summary>
        public virtual string P29 { get; set; }


        /// <summary>
        /// There are no comments for P210 in the schema.
        /// </summary>
        public virtual string P210 { get; set; }


        /// <summary>
        /// There are no comments for P211 in the schema.
        /// </summary>
        public virtual string P211 { get; set; }


        /// <summary>
        /// There are no comments for P212 in the schema.
        /// </summary>
        public virtual decimal? P212 { get; set; }


        /// <summary>
        /// There are no comments for P106 in the schema.
        /// </summary>
        public virtual decimal? P106 { get; set; }


        /// <summary>
        /// There are no comments for P107 in the schema.
        /// </summary>
        public virtual decimal? P107 { get; set; }


        /// <summary>
        /// There are no comments for P108 in the schema.
        /// </summary>
        public virtual decimal? P108 { get; set; }


        /// <summary>
        /// There are no comments for P109 in the schema.
        /// </summary>
        public virtual decimal? P109 { get; set; }


        /// <summary>
        /// There are no comments for P110 in the schema.
        /// </summary>
        public virtual decimal? P110 { get; set; }


        /// <summary>
        /// There are no comments for P111 in the schema.
        /// </summary>
        public virtual decimal? P111 { get; set; }


        /// <summary>
        /// There are no comments for P112 in the schema.
        /// </summary>
        public virtual decimal? P112 { get; set; }


        /// <summary>
        /// There are no comments for P113 in the schema.
        /// </summary>
        public virtual decimal? P113 { get; set; }


        /// <summary>
        /// There are no comments for P114 in the schema.
        /// </summary>
        public virtual decimal? P114 { get; set; }


        /// <summary>
        /// There are no comments for P115 in the schema.
        /// </summary>
        public virtual decimal? P115 { get; set; }


        /// <summary>
        /// There are no comments for P116 in the schema.
        /// </summary>
        public virtual decimal? P116 { get; set; }


        /// <summary>
        /// There are no comments for P117 in the schema.
        /// </summary>
        public virtual decimal? P117 { get; set; }


        /// <summary>
        /// There are no comments for P118 in the schema.
        /// </summary>
        public virtual decimal? P118 { get; set; }


        /// <summary>
        /// There are no comments for TTYPE in the schema.
        /// </summary>
        public virtual int? TTYPE { get; set; }


        /// <summary>
        /// There are no comments for IdOrg in the schema.
        /// </summary>
        public virtual string IdOrg { get; set; }
    }

}
