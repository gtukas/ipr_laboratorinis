using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LaboratonisDarbas
{
    public class Ivestis
    {
        public static List<Studentas> NaujasStudentas(List<Studentas> grupe)
        {
            string vardas, pavarde;
            int n, balas;
            Random random = new Random();
            Console.WriteLine("Studento vardas:");
            vardas = Console.ReadLine();
            Console.WriteLine("Studento pavarde:");
            pavarde = Console.ReadLine();

            try
            {
                grupe.Add(new Studentas(vardas, pavarde));
            }
            catch
            {
                Console.WriteLine("Negaliu pridedi naujo studento :(");
                return grupe;
            }

            Console.WriteLine("Namu darbu uzduociu skaicius:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                balas = random.Next(1, 11);
                Console.WriteLine("{0} Namu darbo balas: {1}", i, balas);
                try
                {
                    grupe.Last().ivestiNamuDarboBala(balas);
                }
                catch
                {
                    Console.WriteLine("Negaliu pridedi namu darbo balo :(");
                    grupe.Remove(grupe.Last());
                    return grupe;
                }
            }

            balas = random.Next(1, 11);
            Console.WriteLine("Egzamino balas: {0}", balas);
            try
            {
                grupe.Last().ivestiEgzaminoBala(balas);
            }
            catch
            {
                Console.WriteLine("Negaliu pridedi egzamino balo :(");
                grupe.Remove(grupe.Last());
                return grupe;
            }

            return grupe;
        }

        public static List<Studentas> NaujasStudentasIsFailo(List<Studentas> grupe)
        {
            Console.WriteLine("Iveskite failo vieta (path):");
            var path = Console.ReadLine();
            if (File.Exists(path))
            {
                var tekstas = File.ReadAllLines(path);
                var title = tekstas[0].Split(' ');
                int n = 1;
                while (n < tekstas.Length)
                {
                    var eilute = tekstas[n].Split(' ');
                    grupe.Add(new Studentas(eilute[0], eilute[1]));
                    for (int i = 2; i < title.Length - 1; i++)
                    {
                        grupe.Last().ivestiNamuDarboBala(int.Parse(eilute[i]));
                    }
                    grupe.Last().ivestiEgzaminoBala(int.Parse(eilute[title.Length - 1]));
                    n++;
                }
            }
            else
            {
                Console.WriteLine("Failas \"{0}\" neegzistuoja!",path);
            }
            return grupe;
        }
        
    }
}
