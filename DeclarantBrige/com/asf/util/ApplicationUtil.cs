using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.asf.util {

    /// <summary>
    /// Общие методы для приложения
    /// </summary>
    static class ApplicationUtil {

        public static void showMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public static bool showQuestion(string msg)
        {
            return MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes;
        }

    }
}
