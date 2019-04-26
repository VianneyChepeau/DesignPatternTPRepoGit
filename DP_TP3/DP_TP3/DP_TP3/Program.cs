using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque banque1 = Banque.getInstance();
            Banque banque2 = Banque.getInstance(); 

            Humain humain1 = new Humain("remy",50000);
            Humain humain2 = new Humain("vianney",50000);

            banque1.payer(20000);
            humain1.encaisser(20000);

            banque2.payer(10000);
            humain2.encaisser(10000);

            Console.WriteLine("Banque1: cash = " + banque1.getCash());
            Console.WriteLine("humain1: cash = " + humain1.getCash());
            Console.WriteLine("Banque2: cash = " + banque2.getCash());
            Console.WriteLine("humain2: cash = " + humain2.getCash());
            Console.ReadKey();
        }
    }
}
