using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP
{
    public class Robot : IEmployer
    {
        public Robot()
        {

        }

        public void travailler()
        {
            Console.WriteLine("Je suis un Robot et je travaille");
        }
    }
}