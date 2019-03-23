using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("Isvesti rezultatus? Spauskite 2.");
                Console.WriteLine("Baigti darba? Spauskite CTRL+C.");
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
                            IsvestiRezultatus();
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

        static void IsvestiRezultatus()
        {
            Console.WriteLine("Skaiciuoti pagal vidurki? spauskite 1");
            Console.WriteLine("Skaiciuoti pagal mediana? spauskite 2");
            int kuris = int.Parse(Console.ReadLine());
            if (kuris == 1)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Vardas", "Pavarde", "Galutinis (vid.)");
                Console.WriteLine("----------------------------------------------------------");
                foreach (var stud in grupe)
                {
                    Console.WriteLine("{0,-20} {1,-20} {2,-20:f2}", stud.vardas, stud.pavarde, stud.galutinisVertinimasVidurkis());
                }
            }
            else {
                Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Vardas", "Pavarde", "Galutinis (med.)");
                Console.WriteLine("----------------------------------------------------------");
                foreach (var stud in grupe)
                {
                    Console.WriteLine("{0,-20} {1,-20} {2,-20:f2}", stud.vardas, stud.pavarde, stud.galutinisVertinimasMediana());
                }
            }
        }
    }
}
