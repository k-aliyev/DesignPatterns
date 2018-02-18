using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ChainOfResponsibility
{
    class Logger
    {
        SmallErrorException simErr;
        ErrorException midErr;
        CritacalErrorException criErr;

        public Logger(string mail) {
            simErr = new SmallErrorException("request is between 0 and 10!");
            midErr = new ErrorException("request is between 11 and 100!!");
            criErr = new CritacalErrorException("request is more than 100!!!", mail);
        }

        public void Exeption(int request)
        {
            if (request >= 0 && request < 10)
            {
                simErr.Error();
            }
            else if (request >= 10 && request < 100) 
            {
                midErr.Error();
            }
            else if (request >= 100)
            {
                criErr.Error();
            }
        }
    }
}
