using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ChainOfResponsibility
{
    class SmallErrorException : Exception
    {
        public SmallErrorException(string messege) : base(messege)
        {

        }

        public void Error()
        {
            Console.WriteLine(Message);
        }
    }

    class ErrorException : Exception
    {
        public ErrorException(string messege) : base(messege)
        {

        }

        public void Error()
        {
            Console.WriteLine(Message);
            Console.WriteLine("Recording to File: Error.txt");
            File.WriteAllText("Error.txt", Message);
        }
    }

    class CritacalErrorException : Exception
    {
        string eMAIL;

        public CritacalErrorException(string messege, string mail) : base(messege)
        {
            eMAIL = mail;
        }

        public void Error()
        {
            Console.WriteLine(Message);
            Console.WriteLine("Recording to File: Error.txt");
            File.WriteAllText("Error.txt", Message);
            Console.WriteLine($"Sending to: {eMAIL}...");

        }
    }
}
