using System.Linq;
using Iesi.Collections.Generic;

namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// ��������� ����������
    /// </summary>
    public partial class DecHeader {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public DecHeader()
        {
            OnCreated();
        }

        /// <summary>
        /// Id �������
        /// </summary>
        public virtual int Id { get; set; }
        
        /// <summary>
        /// Id ����
        /// </summary>
        public virtual int? TypeId { get; set; }

        /// <summary>
        /// �������� ������
        /// </summary>
        public virtual string PrizPeriod { get; set; }
        
        /// <summary>
        /// ������� ����� ����������
        /// </summary>
        public virtual int? PrizFotch { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public virtual int? Yearotch { get; set; }
        
        /// <summary>
        /// ��� ����������
        /// </summary>
        public virtual int? TypePK { get; set; }
        
        /// <summary>
        /// �������������
        /// </summary>
        public virtual string KorrNum { get; set; }


        /// <summary>
        /// ��������(� ������)
        /// </summary>
        public virtual string Lics { get; set; }

        /// <summary>
        /// �������������� � 
        /// </summary>
        public virtual string WhereSubmit { get; set; }

        /// <summary>
        /// ������������� ����� ���������� 11
        /// </summary>
        public virtual ISet<DecF11> Lines11 { get; set; }

        public virtual void addLine11(DecF11 line11)
        {
            line11.Hid = Id;
            Lines11.Add(line11);
        }

        /// <summary>
        /// ����� ������ � 11-� ����������
        /// </summary>
        /// <param name="organizationId">�� �������������</param>
        /// <param name="alcoholCode">��� ��������</param>
        /// <param name="producerId">�� �������������</param>
        /// <returns></returns>
        public virtual DecF11 getLine11(string organizationId, string alcoholCode, int producerId)
        {
            DecF11 decF11 = null;
            var found = Lines11.ToList().FindAll(p =>
                                                 p.IdOrg.Equals(organizationId)
                                                 && p.VidCode.Equals(alcoholCode)
                                                 && p.ProdId.Equals(producerId)
                                                 && p.IdPost == null);
            if(found.Count != 0)
            {
                decF11 = found[0];
            }
            return decF11;
        }

        /// <summary>
        /// �������� ������� �� �����
        /// </summary>
        public virtual void calcRemains11()
        {
            foreach (var line in Lines11)
            {
                line.P120 = (line.P106 + line.P114 - line.P119); 
            }
        }

        /// <summary>
        /// ������������� ����� ���������� 12
        /// </summary>
        public virtual ISet<DecF12> Lines12 { get; set; }

        public virtual void addLine12(DecF12 line12) {
            line12.Hid = Id;
            Lines12.Add(line12);
        }

        /// <summary>
        /// ����� ������ � 12-� ����������
        /// </summary>
        /// <param name="organizationId">�� �������������</param>
        /// <param name="alcoholCode">��� ��������</param>
        /// <param name="producerId">�� �������������</param>
        /// <returns></returns>
        public virtual DecF12 getLine12(string organizationId, string alcoholCode, int producerId) {
            DecF12 decF12 = null;
            var found = Lines12.ToList().FindAll(p =>
                                                 p.IdOrg.Equals(organizationId)
                                                 && p.VidCode.Equals(alcoholCode)
                                                 && p.ProdId.Equals(producerId));
            if (found.Count != 0) {
                decF12 = found[0];
            }
            return decF12;
        }

        /// <summary>
        /// �������� ������� �� �����
        /// </summary>
        public virtual void calcRemains12() {
            foreach (var line in Lines12) {
                line.P118 = (line.P106 + line.P113 - line.P117);
            }
        }

    }

}
