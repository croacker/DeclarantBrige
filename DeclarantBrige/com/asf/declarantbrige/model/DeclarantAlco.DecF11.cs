namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// ������ ���������� 11
    /// </summary>
    public partial class DecF11 {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public DecF11()
        {
            OnCreated();
        }


        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual int Id { get; set; }


        /// <summary>
        /// Id ���������
        /// </summary>
        public virtual int? Hid { get; set; }

        /// <summary>
        /// ���������
        /// </summary>
        //public virtual DecHeader Header { get; set; }

        /// <summary>
        /// ��� ���� ����������� ���������
        /// </summary>
        public virtual string VidCode { get; set; }

        /// <summary>
        /// ��� ����������� ���������
        /// </summary>
        //public virtual RefAlckind AlkoholKind { get; set; }

        /// <summary>
        /// Id �������������
        /// </summary>
        public virtual int? ProdId { get; set; }

        /// <summary>
        /// �������������
        /// </summary>
        //public virtual WrkContragent Producer { get; set; }

        /// <summary>
        /// Id ����������
        /// </summary>
        public virtual int? IdPost { get; set; }

        /// <summary>
        /// ��������� IdPost
        /// </summary>
       // public virtual WrkContragent Suplier { get; set; }

        /// <summary>
        /// Id �������� ����������
        /// </summary>
        public virtual int? IdLic { get; set; }

        /// <summary>
        /// ���� �������
        /// </summary>
        public virtual string P213 { get; set; }


        /// <summary>
        /// ���
        /// </summary>
        public virtual string P214 { get; set; }


        /// <summary>
        /// ���������� ����������
        /// </summary>
        public virtual string P215 { get; set; }


        /// <summary>
        /// ����� ���������
        /// </summary>
        public virtual decimal? P216 { get; set; }


        /// <summary>
        /// ������� �� ������
        /// </summary>
        public virtual decimal? P106 { get; set; }


        /// <summary>
        /// ����������� �� �������������
        /// </summary>
        public virtual decimal? P107 { get; set; }


        /// <summary>
        /// ����������� �� ��������
        /// </summary>
        public virtual decimal? P108 { get; set; }


        /// <summary>
        /// ����������� �� �������
        /// </summary>
        public virtual decimal? P109 { get; set; }


        /// <summary>
        /// ������� �����
        /// </summary>
        public virtual decimal? P110 { get; set; }


        /// <summary>
        /// ������� �� ����������
        /// </summary>
        public virtual decimal? P111 { get; set; }


        /// <summary>
        /// ������ �����������
        /// </summary>
        public virtual decimal? P112 { get; set; }


        /// <summary>
        /// �����������
        /// </summary>
        public virtual decimal? P113 { get; set; }


        /// <summary>
        /// ����������� �����
        /// </summary>
        public virtual decimal? P114 { get; set; }


        /// <summary>
        /// ������ �������
        /// </summary>
        public virtual decimal? P115 { get; set; }


        /// <summary>
        /// ������ ������
        /// </summary>
        public virtual decimal? P116 { get; set; }


        /// <summary>
        /// ������� ����������
        /// </summary>
        public virtual decimal? P117 { get; set; }


        /// <summary>
        /// ������ �����������
        /// </summary>
        public virtual decimal? P118 { get; set; }


        /// <summary>
        /// ������ �����
        /// </summary>
        public virtual decimal? P119 { get; set; }


        /// <summary>
        /// ������� �� �����
        /// </summary>
        public virtual decimal? P120 { get; set; }


        /// <summary>
        /// ���� 1 ��� 2
        /// </summary>
        public virtual int? TTYPE { get; set; }


        /// <summary>
        /// id �����������/�������������
        /// </summary>
        public virtual string IdOrg { get; set; }
    }

}
