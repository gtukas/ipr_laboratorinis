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
            while (testi)
            {
                Console.WriteLine("Ivesti nauja studenta? Spauskite 1.");
                Console.WriteLine("Ivesti naujus studentu is failo? Spauskite 2.");
                Console.WriteLine("Isvesti rezultatus? Spauskite 3.");
                Console.WriteLine("Generate random list? Spauskite 4.");
                Console.WriteLine("Baigti darba? Spauskite e.");
                string ans = Console.ReadLine();
                switch (ans)
                {
                    case "1":
                        {
                            grupe = Ivestis.NaujasStudentas(grupe);
                            break;
                        }
                    case "2":
                        {
                            grupe = Ivestis.NaujasStudentasIsFailo(grupe);
                            break;
                        }
                    case "3":
                        {
                            Isvestis.IsvestiRezultatus(grupe);
                            break; 
                        }
                    case "4":
                        {
                            Console.WriteLine("Iveskite failo vieta (path):");
                            var path = Console.ReadLine();
                            Console.WriteLine("Namu darbu uzduociu skaicius:");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Studentu skaicius:");
                            int st = int.Parse(Console.ReadLine());
                            Ivestis.GenerateRandomStudentList(st,n,path);
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
    }
}
