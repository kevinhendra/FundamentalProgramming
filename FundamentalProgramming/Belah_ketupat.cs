using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalProgramming
{
    class Belah_ketupat
    {
        private float d1, d2, sisi;

        public void inputBelahKetupat()
        {
            Console.Write("Masukkan Diagonal 1 : ");
            d1 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan Diagonal 2 : ");
            d2 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan Sisi : ");
            sisi = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Luas : " + (0.5 * d1 * d2));
            Console.WriteLine("Keliling : " + (4 * sisi));
        }
    }
}
