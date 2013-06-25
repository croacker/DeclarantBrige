using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using com.asf.util;

namespace DeclarantBrige {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            using (var mutex = new Mutex(true, Application.ProductName))
            {
                if (mutex.WaitOne(TimeSpan.FromSeconds(3))){
                    log4net.Config.XmlConfigurator.Configure();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainFrm(ShellArgumentsProcessor.processArguments(args)));
                }
            }
        }
    }
}

