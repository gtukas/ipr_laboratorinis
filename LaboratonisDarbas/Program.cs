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
        private static LinkedList<Studentas> grupeLinkedList = new LinkedList<Studentas>();
        private static List<Studentas> vargsiukai = new List<Studentas>();
        private static LinkedList<Studentas> vargsiukaiLinkedList = new LinkedList<Studentas>();
        private static List<Studentas> kietiakai = new List<Studentas>();
        private static LinkedList<Studentas> kietiakaiLinkedList = new LinkedList<Studentas>();
        private static bool testi = true;
        private static System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            
        static void Main(string[] args)
        {
            while (testi)
            {
                Console.WriteLine("Ivesti nauja studenta? Spauskite 1.");
                Console.WriteLine("Ivesti naujus studentu is failo? Spauskite 2.");
                Console.WriteLine("Isvesti rezultatus? Spauskite 3.");
                Console.WriteLine("Generate random list? Spauskite 4.");
                Console.WriteLine("!!!Naujas rusiavimo pasirinkimas isvalys buvusio surusiavimo rezultatus!!!");
                Console.WriteLine("Surusiuoti studentus i vargsiukus ir kietiakus 2 budas? Spauskite 5.");
                Console.WriteLine("Surusiuoti studentus i vargsiukus ir kietiakus 1 budas? Spauskite 5.");
                Console.WriteLine("Surasyti vargsiukus ir kietiakus i failus? Spauskite 7.");
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
                            Console.WriteLine("List studentu sarasas:");
                            watch.Start();
                            grupe = Ivestis.NaujasStudentasIsFailo(grupe);
                            watch.Stop();
                            Console.WriteLine("It took me {0} miliseconds to read from file to List", watch.ElapsedMilliseconds);
                            watch.Reset();
                            Console.WriteLine("Linked List studentu sarasas:");
                            watch.Start();
                            grupeLinkedList = Ivestis.NaujasStudentasIsFailoLinkedList(grupeLinkedList);
                            watch.Stop();
                            Console.WriteLine("It took me {0} miliseconds to read from file to Linked List", watch.ElapsedMilliseconds);
                            break;
                        }
                    case "3":
                        {
                            Isvestis.IsvestiRezultatus(grupe);
                            break; 
                        }
                    case "4":
                        {
                            Console.WriteLine("Namu darbu uzduociu skaicius:");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Studentu skaicius:");
                            int st = int.Parse(Console.ReadLine());
                            Ivestis.GenerateRandomStudentList(st,n);
                            break;
                        }
                    case "5":
                        {
                            vargsiukai.Clear();
                            vargsiukaiLinkedList.Clear();
                            kietiakai.Clear();
                            kietiakaiLinkedList.Clear();
                            Console.WriteLine("Studentu rusiavimas 2 budas.");
                            watch.Reset();
                            watch.Start();
                            var result = RusiuotiStudentus.surusiuotiStudentaiListas_budas2(grupe);
                            watch.Stop();
                            Console.WriteLine("It took me {0} miliseconds to sort List", watch.ElapsedMilliseconds);
                            vargsiukai = result[1];
                            kietiakai = result[0];
                            
                            watch.Reset();
                            watch.Start();
                            var result2 = RusiuotiStudentus.surusiuotiStudentaiLinkedListas_budas2(grupeLinkedList);
                            watch.Stop();
                            Console.WriteLine("It took me {0} miliseconds to sort Linked List", watch.ElapsedMilliseconds);
                            vargsiukaiLinkedList = result2[1];
                            kietiakaiLinkedList = result2[0];
                            break;
                        }
                      case "6":
                        {
                            vargsiukai.Clear();
                            vargsiukaiLinkedList.Clear();
                            kietiakai.Clear();
                            kietiakaiLinkedList.Clear();
                            Console.WriteLine("Studentu rusiavimas 1 budas:");
                            watch.Reset();
                            watch.Start();
                            var result = RusiuotiStudentus.surusiuotiStudentaiListas_budas1(grupe);
                            watch.Stop();
                            Console.WriteLine("It took me {0} miliseconds to sort List", watch.ElapsedMilliseconds);
                            vargsiukai = result[1];
                            kietiakai = result[0];
                            
                            watch.Reset();
                            watch.Start();
                            var result2 = RusiuotiStudentus.surusiuotiStudentaiLinkedListas_budas1(grupeLinkedList);
                            watch.Stop();
                            Console.WriteLine("It took me {0} miliseconds to sort Linked List", watch.ElapsedMilliseconds);
                            vargsiukaiLinkedList = result2[1];
                            kietiakaiLinkedList = result2[0];
                            break;
                        }
                    case "7":
                        {
                            string fileName = "C:\\temp\\kietiakai.txt";
                            Isvestis.IrasytiIFaila(kietiakai, fileName);
                            fileName = "C:\\temp\\vargsiukai.txt";
                            Isvestis.IrasytiIFaila(vargsiukai, fileName);
                            fileName = "C:\\temp\\kietiakaiLinkedList.txt";
                            Isvestis.IrasytiIFaila(kietiakai, fileName);
                            fileName = "C:\\temp\\vargsiukaiLinkedList.txt";
                            Isvestis.IrasytiIFaila(vargsiukaiLinkedList, fileName);
                            Console.WriteLine("Failai isaugoti C:\\temp\\");
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
