using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.asf.declarantbrige.checker;
using com.asf.declarantbrige.model;

namespace com.asf.declarantbrige.checker {

    /// <summary>
    /// Класс для проверки декларации
    /// </summary>
    class DeclarationChecker : IModelChecker
    {
        /// <summary>
        /// Проверить модель декларации
        /// </summary>
        /// <param name="decHeader"></param>
        public void checkModel(DecHeader decHeader)
        {
            foreach (var line11 in decHeader.Lines11)
            {
                if(line11.IdPost != null)
                {
                    WrkContrLicense contragentLicense =
                        ServiceFactory.getInstance().HibernateService.getContragentLicenseByContragentId((int) line11.IdPost);
                    if (contragentLicense != null)
                    {
                        line11.IdLic = contragentLicense.Id;
                    }
                }
            }
            ServiceFactory.getInstance().HibernateService.saveOrUpdate(decHeader);
        }

    }
}
