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
                            //NaujasStudentas();
                            break;
                        }
                    case "2":
                        {
                            //NaujasStudentasIsFailo();
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
