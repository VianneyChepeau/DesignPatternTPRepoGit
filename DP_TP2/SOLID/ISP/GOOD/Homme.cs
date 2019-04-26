using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP
{
    public class Homme : IEmployer, IHumain
    {
        public Homme()
        {

        }

        public void dormir()
        {
            Console.WriteLine("Je suis un Homme et je dors");
        }

        public void manger()
        {
            Console.WriteLine("Je suis un Homme et je mange");
        }

        public void travailler()
        {
            Console.WriteLine("Je suis un Homme et je travaille");
        }
    }
}