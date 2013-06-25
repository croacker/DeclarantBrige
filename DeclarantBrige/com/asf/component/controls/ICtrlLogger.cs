using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.asf.component {

    /// <summary>
    /// Интерфейс для контрола логирования
    /// </summary>
    public interface ICtrlLogger
    {

        void addLogLine(string msg);

    }
}
