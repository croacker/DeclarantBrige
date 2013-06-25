using System;
using System.Windows.Forms;

namespace com.asf.component {

    /// <summary>
    /// Лист бокс для логирования
    /// </summary>
    class LogListBox : ListBox, ICtrlLogger {
        
        /// <summary>
        /// Добавить запись лога
        /// </summary>
        /// <param name="msg"></param>
        public void addLogLine(string msg)
        {
            Items.Add(DateTime.Now + ": " + msg);
        }

    }
}
