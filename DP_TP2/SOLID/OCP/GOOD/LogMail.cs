using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    public class LogMail : Logger
    {
        public override void WriteLog(string message)
        {
            Console.WriteLine("écriture de log pour le type LogMail");
        }
    }
}