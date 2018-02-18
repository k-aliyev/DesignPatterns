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
            Logger l = new Logger("k.aliyev.1234@gmail.com");
            l.Exeption(101);

        }
    }
}
