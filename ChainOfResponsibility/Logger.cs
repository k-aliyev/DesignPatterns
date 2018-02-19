using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;

namespace ChainOfResponsibility
{
    abstract class Logger
    {
        public abstract void Log(Exception ex);
    }

    class ConsoleLogger : Logger
    {
        FileLogger logger;

        public ConsoleLogger(FileLogger logger)
        {
            this.logger = logger;
        }

        public override void Log(Exception ex)
        {
            Console.WriteLine(ex.Message);
            if((ex as ErrorException).GetErrorType() != TypeError.Small)
            {
                logger.Log(ex);
            }
        }
    }



    class FileLogger : Logger
    {
        MailLogger logger;

        public FileLogger(MailLogger logger)
        {
            this.logger = logger;
        }

        public override void Log(Exception ex)
        {
            Console.WriteLine("Recording to File: Error.txt");
            File.AppendAllText("Error.txt", ex.Message);
            if ((ex as ErrorException).GetErrorType() != TypeError.Middle)
            {
                logger.Log(ex);
            }
        }
    }

    class MailLogger : Logger
    {
        public MailLogger()
        {
        }

        public override void Log(Exception ex)
        {
            Console.WriteLine($"Sending mail to:{(ex as ErrorException).GetMail()}");           
        }
    }
}
