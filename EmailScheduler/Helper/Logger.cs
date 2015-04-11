namespace Utility
{
    using System;
    using System.Diagnostics;

    public static class Logger
    {
        public static void Error(string message)
        {
            WriteEntry(message, "error");
        }

        public static void Error(Exception ex)
        {
            WriteEntry(ex.Message, "error");
        }

        public static void Warning(string message)
        {
            WriteEntry(message, "warning");
        }

        public static void Info(string message)
        {
            WriteEntry(message, "info");
        }

        private static void WriteEntry(string message, string type)
        {
            Trace.WriteLine(string.Format("{0}, {1}, {2}", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), type, message));
        }
    }
}
