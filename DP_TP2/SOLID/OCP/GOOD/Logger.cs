using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    public abstract class Logger
    {
        public abstract void WriteLog(string message);
    }
}