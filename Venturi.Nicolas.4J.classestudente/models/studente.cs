using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturi.Nicolas._4J.classestudente.models
{
    class Studente
    {
        private string _cognome;
        private int _assenze;

        public string cognome
        {
            get
            {
                return _cognome;
            }

            set
            {
                _cognome = value;
            }
        }

        public int assenze
        {
            get
            {
                return _assenze;
            }

            set
            {
                _assenze = value;
            }
        }

        public  Studente(string s, int a)
        {
            cognome = s;
            assenze = 0;
        }

        public int aggiungiassenze(string s, int a)
        {
            int asse = a;
            asse++;
            return asse;
        }

        public override string ToString()
        {
            string linea;
            linea = "lo studente " + cognome + " ha collezionato " + assenze + " assenze";
            return linea;
        }
    }
}
