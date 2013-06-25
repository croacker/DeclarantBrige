using System.Linq;
using Iesi.Collections.Generic;

namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Заголовок декларации
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
        /// Id Объекта
        /// </summary>
        public virtual int Id { get; set; }
        
        /// <summary>
        /// Id типа
        /// </summary>
        public virtual int? TypeId { get; set; }

        /// <summary>
        /// Отчетный период
        /// </summary>
        public virtual string PrizPeriod { get; set; }
        
        /// <summary>
        /// Признак формы отчетности
        /// </summary>
        public virtual int? PrizFotch { get; set; }

        /// <summary>
        /// Год
        /// </summary>
        public virtual int? Yearotch { get; set; }
        
        /// <summary>
        /// Тип декларации
        /// </summary>
        public virtual int? TypePK { get; set; }
        
        /// <summary>
        /// Корректировка
        /// </summary>
        public virtual string KorrNum { get; set; }


        /// <summary>
        /// Лицензии(в строку)
        /// </summary>
        public virtual string Lics { get; set; }

        /// <summary>
        /// Представляется в 
        /// </summary>
        public virtual string WhereSubmit { get; set; }

        /// <summary>
        /// Многострочная часть декларации 11
        /// </summary>
        public virtual ISet<DecF11> Lines11 { get; set; }

        public virtual void addLine11(DecF11 line11)
        {
            line11.Hid = Id;
            Lines11.Add(line11);
        }

        /// <summary>
        /// Найти строку в 11-й декларации
        /// </summary>
        /// <param name="organizationId">ИД подразделения</param>
        /// <param name="alcoholCode">Код алкоголя</param>
        /// <param name="producerId">ИД производителя</param>
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
        /// Рсчитать остатки на конец
        /// </summary>
        public virtual void calcRemains11()
        {
            foreach (var line in Lines11)
            {
                line.P120 = (line.P106 + line.P114 - line.P119); 
            }
        }

        /// <summary>
        /// Многострочная часть декларации 12
        /// </summary>
        public virtual ISet<DecF12> Lines12 { get; set; }

        public virtual void addLine12(DecF12 line12) {
            line12.Hid = Id;
            Lines12.Add(line12);
        }

        /// <summary>
        /// Найти строку в 12-й декларации
        /// </summary>
        /// <param name="organizationId">ИД подразделения</param>
        /// <param name="alcoholCode">Код алкоголя</param>
        /// <param name="producerId">ИД производителя</param>
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
        /// Рсчитать остатки на конец
        /// </summary>
        public virtual void calcRemains12() {
            foreach (var line in Lines12) {
                line.P118 = (line.P106 + line.P113 - line.P117);
            }
        }

    }

}
