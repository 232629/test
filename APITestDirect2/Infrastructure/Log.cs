using System;
using log4net;

namespace APITestDirect2.Infrastructure
{
    /// <summary>
    /// Класс Log. Служит для логирования.
    /// </summary>
    public static class Log
    {
        private static ILog logger;

        static Log()
        {
            logger = LogManager.GetLogger("MainLogger");

            log4net.Appender.RollingFileAppender logappender = new log4net.Appender.RollingFileAppender();
            logappender.File = System.AppDomain.CurrentDomain.BaseDirectory + @"\logs\log.txt";
            logappender.AppendToFile = true;
            logappender.ImmediateFlush = true;
            logappender.Layout = new log4net.Layout.PatternLayout("%d [%-5p] - %m%n");
            logappender.LockingModel = new log4net.Appender.FileAppender.MinimalLock();
            logappender.RollingStyle = log4net.Appender.RollingFileAppender.RollingMode.Once;
            logappender.ActivateOptions();
            log4net.Config.BasicConfigurator.Configure(logappender);
        }

        /// <summary>
        /// Записать в лог сообщение message с уровнем логирования Debug.
        /// </summary>
        /// <param name="message">Форматированная строка сообщения.</param>
        /// <param name="args">Аргументы форматирования.</param>
        public static void Debug(string message, params object[] args)
        {
            logger.DebugFormat(message, args);
        }

        /// <summary>
        /// Записать в лог сообщение message с уровнем логирования Info.
        /// </summary>
        /// <param name="message">Форматированная строка сообщения.</param>
        /// <param name="args">Аргументы форматирования.</param>
        public static void Info(string message, params object[] args)
        {
            logger.InfoFormat(message, args);
        }

        /// <summary>
        /// Записать в лог сообщение message с уровнем логирования Warn.
        /// </summary>
        /// <param name="message">Форматированная строка сообщения.</param>
        /// <param name="args">Аргументы форматирования.</param>
        public static void Warn(string message, params object[] args)
        {
            logger.WarnFormat(message, args);
        }

        /// <summary>
        /// Записать в лог сообщение message с уровнем логирования Error.
        /// </summary>
        /// <param name="message">Форматированная строка сообщения.</param>
        /// <param name="args">Аргументы форматирования.</param>
        public static void Error(string message, params object[] args)
        {
            logger.ErrorFormat(message, args);
        }

        /// <summary>
        /// Записать в лог сообщение message с уровнем логирования Error.
        /// </summary>
        public static void Error(string message, Exception ex)
        {
            logger.Error(message, ex);
        }

        /// <summary>
        /// Записать в лог сообщение message с уровнем логирования Warn.
        /// </summary>
        public static void Warn(string message, Exception ex)
        {
            logger.Warn(message, ex);
        }

        /// <summary>
        /// Записать в лог сообщение message с уровнем логирования Fatal.
        /// </summary>
        /// <param name="message">Форматированная строка сообщения.</param>
        /// <param name="args">Аргументы форматирования.</param>
        public static void Fatal(string message, params object[] args)
        {
            logger.FatalFormat(message, args);
        }
    }
}
