﻿using System;
using System.IO;
using System.Reflection;


namespace PromotionEngine.Infrastructure
{

    public static class LogWriter
    {
        private static string m_exePath = string.Empty;

        public static void LogWrite(string logMessage)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + Constants.LogFileName))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception )
            {
            }
        }

        public static void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :");
                txtWriter.WriteLine("  :{0}", logMessage);
                txtWriter.WriteLine("-------------------------------");
            }
            catch (Exception )
            {
            }
        }
    }
}
