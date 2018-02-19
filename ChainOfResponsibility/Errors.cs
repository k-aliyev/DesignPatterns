using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ChainOfResponsibility
{

    enum TypeError
    {
        Small, Middle, Critacal
    }

    class ErrorException : Exception
    {
        string mail;
        TypeError type;

        public ErrorException(string messege, string mail, TypeError type) : base(messege)
        {
            this.mail = mail;
            this.type = type;
        }
        public string GetMail() { return mail; }
        public TypeError GetErrorType() { return type; }
    }
}
