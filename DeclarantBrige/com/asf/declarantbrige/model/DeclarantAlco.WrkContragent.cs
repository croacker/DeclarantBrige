using Iesi.Collections.Generic;

namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Контрагенты
    /// </summary>
    public partial class WrkContragent {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public WrkContragent()
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
        public virtual string CCode { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Index { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string RCode { get; set; }


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
        public virtual int? RefOrgId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string FlSurname { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string FlName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string FlSecname { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual string FlAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string ForeignAddres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int OrgType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? Producer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Liter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? Carrier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Varnumber { get; set; }

        /// <summary>
        /// Лицензии контрагента
        /// </summary>
        public virtual ISet<WrkContrLicense> Licenses { get; set; }

        /// <summary>
        /// Добавить лицензию
        /// </summary>
        public virtual void addLicense(WrkContrLicense license) {
            license.RefContrId = Id;
            Licenses.Add(license);
        }

        /// <summary>
        /// Найти лицензию
        /// </summary>
        /// <param name="licenseNum"></param>
        /// <returns></returns>
        public virtual WrkContrLicense findLicense(string[] licenseNum)
        {
            WrkContrLicense license = null;
            foreach(WrkContrLicense lic in Licenses)
            {
                if(lic.Series.Equals(licenseNum[0].Trim())
                    && lic.Number.Equals(licenseNum[1].Trim()))
                {
                    license = lic;
                    break;
                }
            }
            return license;
        }
    }

}
