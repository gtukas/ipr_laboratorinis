using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LaboratonisDarbas
{
    public class Isvestis
    {
        public static void IsvestiRezultatus(List<Studentas> grupe)
        {
            grupe.Sort(new CompareStudentas());
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20}", "Vardas", "Pavarde", "Galutinis (vid.)", "Galutinis (med.)");
            Console.WriteLine("---------------------------------------------------------------------------------");
            foreach (var stud in grupe)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-20:f2} {3,-20:f2}", stud.vardas, stud.pavarde, stud.galutinisVertinimasVidurkis(), stud.galutinisVertinimasMediana());
            }
            Console.WriteLine("");
        }
        public static void IrasytiIFaila(List<Studentas> grupe, string fileName)
        {
            grupe.Sort(new CompareStudentas());
            List<string> lines = new List<string>();
            lines.Add(string.Format("{0,-20} {1,-20} {2,-20} {3,-20}", "Vardas", "Pavarde", "Galutinis (vid.)", "Galutinis (med.)"));
            lines.Add(string.Format("---------------------------------------------------------------------------------"));
            foreach (var stud in grupe)
            {
                lines.Add(string.Format("{0,-20} {1,-20} {2,-20:f2} {3,-20:f2}", stud.vardas, stud.pavarde, stud.galutinisVertinimasVidurkis(), stud.galutinisVertinimasMediana()));
            }
            File.AppendAllLines(fileName, lines);        
        }
        public static void IrasytiIFaila(LinkedList<Studentas> grupe, string fileName)
        {
            List<string> lines = new List<string>();
            lines.Add(string.Format("{0,-20} {1,-20} {2,-20} {3,-20}", "Vardas", "Pavarde", "Galutinis (vid.)", "Galutinis (med.)"));
            lines.Add(string.Format("---------------------------------------------------------------------------------"));
            foreach (var stud in grupe)
            {
                lines.Add(string.Format("{0,-20} {1,-20} {2,-20:f2} {3,-20:f2}", stud.vardas, stud.pavarde, stud.galutinisVertinimasVidurkis(), stud.galutinisVertinimasMediana()));
            }
            File.AppendAllLines(fileName, lines);     
        }
    }
}
