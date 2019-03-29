using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LaboratonisDarbas
{
    class Program
    {
        private static List<Studentas> grupe = new List<Studentas>();
        private static bool testi = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            while (testi)
            {
                Console.WriteLine("Ivesti nauja studenta? Spauskite 1.");
                Console.WriteLine("Ivesti naujus studentu is failo? Spauskite 2.");
                Console.WriteLine("Isvesti rezultatus? Spauskite 3.");
                Console.WriteLine("Baigti darba? Spauskite e.");
                string ans = Console.ReadLine();
                switch (ans)
                {
                    case "1":
                        {
                            NaujasStudentas();
                            break;
                        }
                    case "2":
                        {
                            NaujasStudentasIsFailo();
                            break;
                        }
                    case "3":
                        {
                            IsvestiRezultatus();
                            break;
                        }
                    case "e":
                        {
                            testi = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nesupratau jusu ivesties. Bandykite dar karta.");
                            break;
                        }

                }
            }
        }

        static void NaujasStudentas()
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

        static void NaujasStudentasIsFailo()
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
                    for (int i = 2; i < title.Length-1; i++)
                    {
                        grupe.Last().ivestiNamuDarboBala(int.Parse(eilute[i]));
                    }
                    grupe.Last().ivestiEgzaminoBala(int.Parse(eilute[title.Length-1]));
                    n++;
                }
            }
        }

        static void IsvestiRezultatus()
        {
            grupe.Sort(new CompareStudentas());
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20}", "Vardas", "Pavarde", "Galutinis (vid.)", "Galutinis (med.)");
            Console.WriteLine("-----------------------------------------------------------------");
            foreach (var stud in grupe)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-20:f2} {3,-20:f2}", stud.vardas, stud.pavarde, stud.galutinisVertinimasVidurkis(), stud.galutinisVertinimasMediana());
            }
        }
    }
}
