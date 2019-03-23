using System;
using System.Collections.Generic;
using System.Linq;

namespace LaboratonisDarbas
{
    public class Studentas
    {
        private List<int> namuDarbai = new List<int>();
        private int egzaminas;
        public string vardas{ get; }
        public string pavarde { get; }

        public Studentas(string vardas, string pavarde)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
        }

        public void ivestiNamuDarboBala(int balas)
        {
            this.namuDarbai.Add(balas);
        }

        public void ivestiEgzaminoBala(int balas)
        {
            this.egzaminas = balas;
        }

        public double namuDarbuBaluVidurkis()
        {
            return this.namuDarbai.Count > 0 ? this.namuDarbai.Average() : 0.0;
        }

        public double namuDarbuBaluMediana()
        {
            int[] numbers = this.namuDarbai.ToArray();
            int numberCount = numbers.Count();
            int halfIndex = numbers.Count() / 2 - 1;
            var sortedNumbers = numbers.OrderBy(n => n);
            double median;
            if ((numberCount % 2) == 0)
            {
                median = (sortedNumbers.ElementAt(halfIndex+1) +
                    sortedNumbers.ElementAt(halfIndex) / 2);
            }
            else
            {
                median = sortedNumbers.ElementAt(halfIndex);
            }
            return median;
        }

        public double galutinisVertinimasVidurkis()
        {
            return 0.3 * this.namuDarbuBaluVidurkis() + 0.7 * this.egzaminas;
        }

        public double galutinisVertinimasMediana()
        {
            return 0.3 * this.namuDarbuBaluMediana() + 0.7 * this.egzaminas;
        }

    }
}
