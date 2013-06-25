using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Context;
using Spring.Context.Support;
using com.asf.component;

namespace com.asf.declarantbrige {

    /// <summary>
    /// Фабрика
    /// </summary>
    abstract class AbstractFactory {

        /// <summary>
        /// Spring Контекст приложения
        /// </summary>
        protected IApplicationContext applicationContext;

        protected static AbstractFactory instance;

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

        /// <summary>
        /// Spring Контекст приложения
        /// </summary>
        public IApplicationContext getApplicationContext() {
            if(applicationContext == null)
            {
                applicationContext = ContextRegistry.GetContext();
            }
            return applicationContext;
        }


    }
}
