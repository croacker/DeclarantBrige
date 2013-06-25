using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.asf.component;

namespace com.asf.declarantbrige.service {

    /// <summary>
    /// Абстрактный сервис
    /// </summary>
    public abstract class AbstractService {

        /// <summary>
        /// Контрол для вывода лога
        /// </summary>
        public ICtrlLogger CtrlLogger { get; set; }

        /// <summary>
        /// Вывод сообщения в лог
        /// </summary>
        /// <param name="msg"></param>
        protected virtual void addLogLine(string msg) {
            if (CtrlLogger != null) {
                CtrlLogger.addLogLine(msg);
            }
        }

    }
}
