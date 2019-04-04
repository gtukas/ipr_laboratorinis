using System;
using System.Collections.Generic;
using System.Linq;

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

            grupe.Add(new Studentas(vardas, pavarde));

            Console.WriteLine("Namu darbu uzduociu skaicius:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                balas = random.Next(1, 11);
                Console.WriteLine("{0} Namu darbo balas: {1}", i, balas);
                grupe.Last().ivestiNamuDarboBala(balas);
            }

            balas = random.Next(1, 11);
            Console.WriteLine("Egzamino balas: {0}", balas);
            grupe.Last().ivestiEgzaminoBala(balas);
        }

        public static void NaujasStudentasIsFailo()
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
        }
        
    }
}
