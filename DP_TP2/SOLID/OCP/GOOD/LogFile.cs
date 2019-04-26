using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    public class LogFile : Logger
    {
        public override void WriteLog(string message)
        {
            Console.WriteLine("écriture de log pour le type LogFile");
        }
    }
}