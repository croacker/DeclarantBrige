using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.asf.util {

    /// <summary>
    /// Обработка входящих аргументов
    /// </summary>
    internal static class ShellArgumentsProcessor {

        public static class Arguments
        {
            public static string LOAD_FOLDER = "loadFolder";
        }

        public static Dictionary<string, string> processArguments(string[] args)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            foreach (var arg in args) {
                if (arg.StartsWith("/f")) {
                    parameters.Add(Arguments.LOAD_FOLDER, arg.Replace("/f", ""));
                }
            }
            return parameters;
        }

    }
}
