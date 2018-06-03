namespace K8_Fly_Cutter
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;

    public static class WriteLogHelper
    {
        public static string m_fileName = string.Empty;
        private static object m_Lock = new object();
        private static string m_LogDirPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        private static string m_LogFile = string.Empty;
        private static Worker m_Worker = new Worker();

        static WriteLogHelper()
        {
            if (!Directory.Exists(m_LogDirPath))
            {
                Directory.CreateDirectory(m_LogDirPath);
            }
        }

        public static string GetFunctionName()
        {
            try
            {
                StackTrace trace = new StackTrace(2);
                if (trace.FrameCount <= 1)
                {
                    return string.Empty;
                }
                MethodBase method = trace.GetFrame(0).GetMethod();
                return string.Format("{0}.{1}", method.ReflectedType.FullName, method.Name);
            }
            catch
            {
            }
            return string.Empty;
        }

        [Conditional("DEBUG")]
        public static void WriteDebug(Exception ex)
        {
            lock (m_Lock)
            {
                m_Worker.WriteLogo(GetFunctionName() + "出错.", ex);
            }
        }

        [Conditional("DEBUG")]
        public static void WriteDebug(string msg)
        {
            lock (m_Lock)
            {
                m_Worker.WriteMessage(msg);
            }
        }

        [Conditional("DEBUG")]
        public static void WriteDebug(string msg, Exception ex)
        {
            lock (m_Lock)
            {
                m_Worker.WriteLogo(msg, ex);
            }
        }

        public static void WriteError(Exception ex)
        {
            lock (m_Lock)
            {
                m_Worker.WriteLogo(GetFunctionName() + "出错.", ex);
            }
        }

        public static void WriteError(string msg)
        {
            lock (m_Lock)
            {
                m_Worker.WriteMessage(msg);
            }
        }

        public static void WriteError(string msg, Exception ex)
        {
            lock (m_Lock)
            {
                m_Worker.WriteLogo(msg, ex);
            }
        }

        private class Worker
        {
            private string baseFileName = (WriteLogHelper.m_LogDirPath + @"\");
            private string exFileName = ".txt";
            private int fileIndex = 0;
            private DateTime logTime = DateTime.Now;

            private void FileIndexControl()
            {
                if (this.logTime.Date != DateTime.Now.Date)
                {
                    this.logTime = DateTime.Now;
                    this.fileIndex = 0;
                    this.baseFileName = WriteLogHelper.m_LogDirPath + @"\";
                    WriteLogHelper.m_LogFile = this.baseFileName + WriteLogHelper.m_fileName;
                }
                else if ((WriteLogHelper.m_LogFile != string.Empty) && File.Exists(WriteLogHelper.m_LogFile))
                {
                    FileInfo info = new FileInfo(WriteLogHelper.m_LogFile);
                    if (info.Length > 0xfa000L)
                    {
                        this.fileIndex++;
                        WriteLogHelper.m_LogFile = this.baseFileName + WriteLogHelper.m_fileName;
                    }
                }
                else if ((WriteLogHelper.m_LogFile == string.Empty) || (WriteLogHelper.m_LogFile.Length == 0))
                {
                    WriteLogHelper.m_LogFile = this.baseFileName + WriteLogHelper.m_fileName;
                }
            }

            public void WriteLogo(string msg, Exception ex)
            {
                this.FileIndexControl();
                using (StreamWriter writer = File.AppendText(WriteLogHelper.m_LogFile))
                {
                    writer.WriteLine(msg);
                }
            }

            public void WriteMessage(string msg)
            {
                this.FileIndexControl();
                using (StreamWriter writer = File.AppendText(WriteLogHelper.m_LogFile))
                {
                    writer.WriteLine(msg);
                }
            }
        }
    }
}

