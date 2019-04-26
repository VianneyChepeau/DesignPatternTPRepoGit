using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP.BAD
{
    class Program
    {
        public static void Main (string[] args)
        {
            Logger log;

            log = new DBLog();

            log.WriteLog("ceci est un message");
        }
    }
}
