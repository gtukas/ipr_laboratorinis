using System;

namespace LaboratonisDarbas
{
    class CompareStudentas : IComparer<Studentas>
    {
        public Studentas Compare(Studentas x, Studentas y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }

            // CompareTo() method 
            return x.CompareTo(y);

        }
    }
}
