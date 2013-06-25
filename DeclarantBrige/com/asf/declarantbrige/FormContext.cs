using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.asf.declarantbrige.service;

namespace com.asf.declarantbrige {

    /// <summary>
    /// Контекст формы
    /// </summary>
    class FormContext :AbstractContext{
        public FormContext(HibernateService hibernateService) : base(hibernateService)
        {
        }
    }
}
