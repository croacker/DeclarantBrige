namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Строка декларации 6
    /// </summary>
    public partial class DecF6 {

        private int _Id;

        private System.Nullable<int> _Hid;

        private string _VidCode;

        private System.Nullable<int> _ProdId;

        private System.Nullable<int> _IdPost;

        private System.Nullable<int> _IdLic;

        private string _P14;

        private string _P15;

        private System.Nullable<decimal> _P16;

        private string _P17;

        private string _P18;

        private string _P19;

        private System.Nullable<decimal> _P20;

        private System.Nullable<int> _TTYPE;

        private string _IdOrg;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public DecF6()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Hid in the schema.
        /// </summary>
        public virtual System.Nullable<int> Hid
        {
            get
            {
                return this._Hid;
            }
            set
            {
                this._Hid = value;
            }
        }

    
        /// <summary>
        /// There are no comments for VidCode in the schema.
        /// </summary>
        public virtual string VidCode
        {
            get
            {
                return this._VidCode;
            }
            set
            {
                this._VidCode = value;
            }
        }

    
        /// <summary>
        /// There are no comments for ProdId in the schema.
        /// </summary>
        public virtual System.Nullable<int> ProdId
        {
            get
            {
                return this._ProdId;
            }
            set
            {
                this._ProdId = value;
            }
        }

    
        /// <summary>
        /// There are no comments for IdPost in the schema.
        /// </summary>
        public virtual System.Nullable<int> IdPost
        {
            get
            {
                return this._IdPost;
            }
            set
            {
                this._IdPost = value;
            }
        }

    
        /// <summary>
        /// There are no comments for IdLic in the schema.
        /// </summary>
        public virtual System.Nullable<int> IdLic
        {
            get
            {
                return this._IdLic;
            }
            set
            {
                this._IdLic = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P14 in the schema.
        /// </summary>
        public virtual string P14
        {
            get
            {
                return this._P14;
            }
            set
            {
                this._P14 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P15 in the schema.
        /// </summary>
        public virtual string P15
        {
            get
            {
                return this._P15;
            }
            set
            {
                this._P15 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P16 in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> P16
        {
            get
            {
                return this._P16;
            }
            set
            {
                this._P16 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P17 in the schema.
        /// </summary>
        public virtual string P17
        {
            get
            {
                return this._P17;
            }
            set
            {
                this._P17 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P18 in the schema.
        /// </summary>
        public virtual string P18
        {
            get
            {
                return this._P18;
            }
            set
            {
                this._P18 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P19 in the schema.
        /// </summary>
        public virtual string P19
        {
            get
            {
                return this._P19;
            }
            set
            {
                this._P19 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P20 in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> P20
        {
            get
            {
                return this._P20;
            }
            set
            {
                this._P20 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for TTYPE in the schema.
        /// </summary>
        public virtual System.Nullable<int> TTYPE
        {
            get
            {
                return this._TTYPE;
            }
            set
            {
                this._TTYPE = value;
            }
        }

    
        /// <summary>
        /// There are no comments for IdOrg in the schema.
        /// </summary>
        public virtual string IdOrg
        {
            get
            {
                return this._IdOrg;
            }
            set
            {
                this._IdOrg = value;
            }
        }
    }

}
