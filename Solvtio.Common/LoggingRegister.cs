using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Solvtio.Common
{
    public class LoggingRegister
    {
        private string File;

        public LoggingRegister()
        {
            string logFileName = Path.Combine(System.Environment.CurrentDirectory, "LoggingRegister_");

            File = string.Format("{0}{1}.log", 
                logFileName, 
                Guid.NewGuid().ToString().Replace("-", ""));
        }
        public LoggingRegister(string logFileName)
        {
            File = string.Format("{0}{1}.log", logFileName, Guid.NewGuid().ToString().Replace("-", ""));
        }

        public bool Register(string mensaje)
        {
            System.IO.File.AppendAllText(File, string.Format("{0} - {1}{2}", DateTime.Now, mensaje, Environment.NewLine));
            return true;
        }

        public bool Register(string msgHead, IList<string> errores)
        {
            StringBuilder sb = new StringBuilder(string.Format("{0} ({1})", msgHead, errores.Count));
            foreach (var item in errores)
	        {
                sb.AppendLine(string.Format("    {0}", item));
	        }
            sb.AppendLine("");

            return Register(sb.ToString());
        }

        public bool Register(string msgHead, Exception ex)
        {
            StringBuilder sb = new StringBuilder(string.Format("{0}", msgHead));
            
            sb.AppendLine(string.Format("    Message: {0}", ex.Message));
            sb.AppendLine(string.Format("    InnerException: {0}", ex.InnerException));
	        sb.AppendLine("");

            return Register(sb.ToString());
        }

    }
}






