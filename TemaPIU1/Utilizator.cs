using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    public class Utilizator
    {
        string Nume;
        string Prenume;
        int Buget;
        public Utilizator(string _Nume,string _Prenume,int _Buget)
        {
            Nume = _Nume;
            Prenume = _Prenume;
            Buget = _Buget;
        }
        //nou ex1 lab 4
        public string ConversieLaSir()
        {

            string s=string.Format("Utilizatorul {0} {1} are bugetul {2} Euro",Nume,Prenume,Buget);
            return s;
        }
        //nou ex2 lab 4
        public string compara(Utilizator utilizator)
        {
            if (Buget < utilizator.Buget)
                return"utilizatorul "+utilizator.Nume+" are mai multi bani";
            else if (Buget == utilizator.Buget)
                return"utilizatorii au acelasi buget";
            else
                return"utilizatorul "+Nume+ " are mai multi bani";
        }
    }
}
