using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using log4net.Repository;

namespace Notepad_Application.Services
{
    internal class LoggingService
    {
        public static void ConfigureLogging()
        {
            ILoggerRepository repository = LogManager.GetRepository();

            var layout = new PatternLayout
            {
                ConversionPattern = "%newline %date %-5level %logger - %message %newline %newline"
            };
            layout.ActivateOptions();

            var fileAppender = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NotepadManager.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = log4net.Core.Level.Info
            };
            fileAppender.ActivateOptions();

            BasicConfigurator.Configure(repository, fileAppender);
        }
    }
}
