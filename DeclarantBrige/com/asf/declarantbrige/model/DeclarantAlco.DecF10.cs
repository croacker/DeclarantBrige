namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Строка декларации 10
    /// </summary>
    public partial class DecF10 {

        private int _Id;

        private System.Nullable<int> _Hid;

        private string _Adress;

        private System.Nullable<int> _VidLic;

        private string _VidCodeDescr;

        private string _VidCode;

        private System.Nullable<decimal> _Norma;

        private System.Nullable<decimal> _Power;

        private System.Nullable<decimal> _P1;

        private System.Nullable<decimal> _P2;

        private System.Nullable<decimal> _P3;

        private System.Nullable<decimal> _P4;

        private System.Nullable<decimal> _P5;

        private System.Nullable<decimal> _Koeff;

        private string _IdOrg;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public DecF10()
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
        /// There are no comments for Adress in the schema.
        /// </summary>
        public virtual string Adress
        {
            get
            {
                return this._Adress;
            }
            set
            {
                this._Adress = value;
            }
        }

    
        /// <summary>
        /// There are no comments for VidLic in the schema.
        /// </summary>
        public virtual System.Nullable<int> VidLic
        {
            get
            {
                return this._VidLic;
            }
            set
            {
                this._VidLic = value;
            }
        }

    
        /// <summary>
        /// There are no comments for VidCodeDescr in the schema.
        /// </summary>
        public virtual string VidCodeDescr
        {
            get
            {
                return this._VidCodeDescr;
            }
            set
            {
                this._VidCodeDescr = value;
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
        /// There are no comments for Norma in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> Norma
        {
            get
            {
                return this._Norma;
            }
            set
            {
                this._Norma = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Power in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> Power
        {
            get
            {
                return this._Power;
            }
            set
            {
                this._Power = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P1 in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> P1
        {
            get
            {
                return this._P1;
            }
            set
            {
                this._P1 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P2 in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> P2
        {
            get
            {
                return this._P2;
            }
            set
            {
                this._P2 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P3 in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> P3
        {
            get
            {
                return this._P3;
            }
            set
            {
                this._P3 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P4 in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> P4
        {
            get
            {
                return this._P4;
            }
            set
            {
                this._P4 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for P5 in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> P5
        {
            get
            {
                return this._P5;
            }
            set
            {
                this._P5 = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Koeff in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> Koeff
        {
            get
            {
                return this._Koeff;
            }
            set
            {
                this._Koeff = value;
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
