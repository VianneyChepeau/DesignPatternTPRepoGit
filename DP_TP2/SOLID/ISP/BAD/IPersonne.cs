using System;
namespace ISP.BAD
{
    public interface IPersonne
    {
        int Age { get; }
        DateTime DateDeNaissance { get; set; }
        void EnvoyerEmail(string msg);
        void EnvoyerSMS(string msg);
        string Nom { get; set; }
        string Prenom { get; set; }
        int Tel { get; set; }
        int Mail { get; set; }
    }
}
