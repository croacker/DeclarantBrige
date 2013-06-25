using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.asf.declarantbrige.model;
using declarant.xml;

namespace com.asf.declarantbrige {

    /// <summary>
    /// Фабрика моделей
    /// </summary>
    class ModelFactory:AbstractFactory {

        private static ModelFactory instance;

        public static ModelFactory getInstance() {
            if (instance == null) {
                instance = new ModelFactory();
            }
            return instance;
        }

        /// <summary>
        /// Создать модель контрагента
        /// </summary>
        /// <param name="contragent"></param>
        /// <returns></returns>
        public WrkContragent createContragent(СправочникиКонтрагенты contragent)
        {
            WrkContragent wrkContragent = new WrkContragent();
            if (contragent.isResident())
            {
                wrkContragent.INN = contragent.getContragentSearchIndex();
            }
            wrkContragent.OrgName = contragent.П000000000007;
            
            return wrkContragent;
        }
 
        /// <summary>
        /// Создать модель лицензии контрагента
        /// </summary>
        /// <param name="license"></param>
        /// <returns></returns>
        public WrkContrLicense createContragentLicense(СправочникиКонтрагентыРезидентЛицензииЛицензия license)
        {
            WrkContrLicense contragentLicense = new WrkContrLicense();

            return contragentLicense;
        }

        /// <summary>
        /// Создать модель строки 11-й декларации
        /// </summary>
        /// <returns></returns>
        public DecF11 createLine11()
        {
            DecF11 decF11 = new DecF11();

            decF11.P106 = 0;
            decF11.P107 = 0;
            decF11.P108 = 0;
            decF11.P109 = 0;
            decF11.P110 = 0;
            decF11.P111 = 0;
            decF11.P112 = 0;
            decF11.P113 = 0;
            decF11.P114 = 0;
            decF11.P115 = 0;
            decF11.P116 = 0;
            decF11.P117 = 0;
            decF11.P118 = 0;
            decF11.P119 = 0;
            decF11.P120 = 0;
            decF11.P216 = 0;

            return decF11;
        }

        /// <summary>
        /// Создать модель строки 12-й декларации
        /// </summary>
        /// <returns></returns>
        public DecF12 createLine12() {
            DecF12 decF12 = new DecF12();

            decF12.P106 = 0;
            decF12.P107 = 0;
            decF12.P108 = 0;
            decF12.P109 = 0;
            decF12.P110 = 0;
            decF12.P111 = 0;
            decF12.P112 = 0;
            decF12.P113 = 0;
            decF12.P114 = 0;
            decF12.P115 = 0;
            decF12.P116 = 0;
            decF12.P117 = 0;
            decF12.P118 = 0;
            decF12.P212 = 0;

            return decF12;
        }

    }
}
