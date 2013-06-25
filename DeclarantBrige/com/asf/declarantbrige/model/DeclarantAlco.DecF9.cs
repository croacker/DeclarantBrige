namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Строка декларации 9
    /// </summary>
    public partial class DecF9 {

        private int _Id;

        private System.Nullable<int> _Hid;

        private System.Nullable<int> _VidTraffic;

        private string _VidCode;

        private System.Nullable<int> _IdContrOtpr;

        private System.Nullable<int> _IdContrPol;

        private string _P6;

        private System.Nullable<decimal> _P7;

        private string _P8;

        private string _P9;

        private string _P10;

        private System.Nullable<decimal> _P11;

        private string _IdOrg;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public DecF9()
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
        /// There are no comments for VidTraffic in the schema.
        /// </summary>
        public virtual System.Nullable<int> VidTraffic
        {
            get
            {
                return this._VidTraffic;
            }
            set
            {
                this._VidTraffic = value;
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
        /// There are no comments for IdContrOtpr in the schema.
        /// </summary>
        public virtual System.Nullable<int> IdContrOtpr
        {
            get
            {
                return this._IdContrOtpr;
            }
            set
            {
                this._IdContrOtpr = value;
            }
        }

    
        /// <summary>
        /// There are no comments for IdContrPol in the schema.
        /// </summary>
        public virtual System.Nullable<int> IdContrPol
        {
            get
            {
                return this._IdContrPol;
            }
            set
            {
                this._IdContrPol = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P6 in the schema.
        /// </summary>
        public virtual string P6
        {
            get
            {
                return this._P6;
            }
            set
            {
                this._P6 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P7 in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> P7
        {
            get
            {
                return this._P7;
            }
            set
            {
                this._P7 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P8 in the schema.
        /// </summary>
        public virtual string P8
        {
            get
            {
                return this._P8;
            }
            set
            {
                this._P8 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P9 in the schema.
        /// </summary>
        public virtual string P9
        {
            get
            {
                return this._P9;
            }
            set
            {
                this._P9 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P10 in the schema.
        /// </summary>
        public virtual string P10
        {
            get
            {
                return this._P10;
            }
            set
            {
                this._P10 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P11 in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> P11
        {
            get
            {
                return this._P11;
            }
            set
            {
                this._P11 = value;
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
