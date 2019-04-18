using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LaboratonisDarbas
{
    public class RusiuotiStudentus
    {
        public static List<List<Studentas>> surusiuotiStudentaiListas_budas2(List<Studentas> grupe)
        {
            List<Studentas> maziauNei5 = new List<Studentas>();
            foreach (var stud in grupe.ToList())
            {
                if (stud.galutinisVertinimasVidurkis() <= 5.0)
                {
                    maziauNei5.Add(stud);
                    grupe.Remove(stud);
                }
            }
            List<List<Studentas>> result = new List<List<Studentas>>();
            result.Add(grupe);
            result.Add(maziauNei5);
            return result;
        }

        public static List<LinkedList<Studentas>> surusiuotiStudentaiLinkedListas_budas2(LinkedList<Studentas> grupe)
        {
            LinkedList<Studentas> maziauNei5 = new LinkedList<Studentas>();
            foreach (var stud in grupe.ToList())
            {
                if (stud.galutinisVertinimasVidurkis() <= 5.0)
                {
                    maziauNei5.AddLast(stud);
                    grupe.Remove(stud);
                }
            }
            List<LinkedList<Studentas>> result = new List<LinkedList<Studentas>>();
            result.Add(grupe);
            result.Add(maziauNei5);
            return result;
        }

        public static List<List<Studentas>> surusiuotiStudentaiListas_budas1(List<Studentas> grupe)
        {
            List<Studentas> maziauNei5 = new List<Studentas>();
            List<Studentas> daugiauNei5 = new List<Studentas>();
            foreach (var stud in grupe.ToList())
            {
                if (stud.galutinisVertinimasVidurkis() <= 5.0)
                {
                    maziauNei5.Add(stud);
                }
                else
                {
                    daugiauNei5.Add(stud);
                }
            }
            List<List<Studentas>> result = new List<List<Studentas>>();
            result.Add(daugiauNei5);
            result.Add(maziauNei5);
            return result;
        }

        public static List<LinkedList<Studentas>> surusiuotiStudentaiLinkedListas_budas1(LinkedList<Studentas> grupe)
        {
            LinkedList<Studentas> maziauNei5 = new LinkedList<Studentas>();
            LinkedList<Studentas> daugiauNei5 = new LinkedList<Studentas>();
            foreach (var stud in grupe.ToList())
            {
                if (stud.galutinisVertinimasVidurkis() <= 5.0)
                {
                    maziauNei5.AddLast(stud);
                }
                else
                {
                    daugiauNei5.AddLast(stud);
                }
            }
            List<LinkedList<Studentas>> result = new List<LinkedList<Studentas>>();
            result.Add(daugiauNei5);
            result.Add(maziauNei5);
            return result;
        }

    }
}
