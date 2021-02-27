using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venturi.Nicolas._4J.classestudente.models;
using System.IO;

namespace Venturi.Nicolas._4J.classestudente
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, i = 0;
            string ricerca, outo="";
            using (StreamReader file = new StreamReader("cognomi.txt"))
            {
                
                string linea;
                while((linea=file.ReadLine())!=null)
                {
                    counter++;
                }
                Studente[] name = new Studente[counter];
                file.BaseStream.Position = 0;
                while ((linea = file.ReadLine()) != null)
                {
                     name[i] = new Studente(linea, 0);
                    i++;
                }
            

            Console.WriteLine("inserisci il cognome dello studente a cui vuoi aggiungere una assenza");
            ricerca = Console.ReadLine();
                i = 0;
            while (i<counter)
            {
                    if (ricerca == name[i].cognome)
                    {
                      name[i].assenze=name[i].aggiungiassenze(name[i].cognome, name[i].assenze);
                    }
                    i++;
            }
                Console.WriteLine("inserisci il cognome dello studente di cui vuoi sapere le assenze");
                ricerca = Console.ReadLine();
                i = 0;
                while (i < counter)
                {
                    if (ricerca == name[i].cognome)
                    {
                       outo =  name[i].ToString();
                    }
                    i++;
                }
                Console.WriteLine(outo);
                Console.ReadLine();
            }
           
        }
    }
}
