using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger ml = new MailLogger();
            Logger fl = new FileLogger(ml as MailLogger);
            Logger cl = new ConsoleLogger(fl as FileLogger); 

            try
            {
                throw  new ErrorException("Oh Fuck!", "someone@gmail.com", TypeError.Critacal);
            }
            catch (Exception ex)
            {
                cl.Log(ex);
            }
        }
    }
}
