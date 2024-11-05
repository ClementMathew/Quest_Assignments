# File Logging

#### Discussed about :

    Concepts of Logging in File.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net.Repository;

namespace File_Logging
{
    internal class File_Logging
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(File_Logging));
        static void Main(string[] args)
        {
            ConfigureLogging();

            try
            {
                Console.Write("Enter num1: ");
                int i = int.Parse(Console.ReadLine());

                Console.Write("Enter num2: ");
                int j = int.Parse(Console.ReadLine());

                int sum = i + j;
                Console.WriteLine("Sum: " + sum);
            }
            catch (Exception e)
            {
                log.Error("An error occurred: " + e.Message);
            }
        }

        private static void ConfigureLogging()
        {
            // Get the repository for the current logger configuration

            ILoggerRepository repository = LogManager.GetRepository();

            // Define layout pattern

            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();

            // Set up a file appender for error logging

            var errorFileAppender = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "error.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Error
            };
            errorFileAppender.ActivateOptions();

            // Basic configuration for both appenders

            BasicConfigurator.Configure(repository, errorFileAppender);
        }
    }
}

```
