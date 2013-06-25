using System.Windows.Forms;
using com.asf.component;

namespace com.asf.declarantbrige.forms {
    public partial class BaseForm : Form {

        public ICtrlLogger CtrlLogger { get; set; }

        public BaseForm() {
            InitializeComponent();
        }

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
