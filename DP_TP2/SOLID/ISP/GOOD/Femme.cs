using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP
{
    public class Femme : IEmployer, IHumain
    {
        public Femme()
        {

        }

        public void dormir()
        {
            Console.WriteLine("Je suis un Femme et je dors");
        }

        public void manger()
        {
            Console.WriteLine("Je suis un Femme et je mange");
        }

        public void travailler()
        {
            Console.WriteLine("Je suis un Femme et je travaille");
        }
    }
}