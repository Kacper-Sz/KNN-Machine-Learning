using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia
{
    public interface IMachine
    {
        public string Klasyfikuj(double[] wektor);
        public void NadpiszIndexy(int[] tablica_indexow);
    }
}
