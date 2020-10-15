using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalProgramming
{
    class Layang
    {
        private float d1, d2, rusuk1, rusuk2;

        public void inputLayang()
        {
            Console.Write("Masukkan Diagonal 1 : ");
            d1 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan Diagonal 2 : ");
            d2 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan rusuk 1 : ");
            rusuk1 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan rusuk 2 : ");
            rusuk2 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Luas : " + (0.5 * d1 * d2));
            Console.WriteLine("Keliling : " + (2 * (rusuk1 + rusuk2)));
        }

       
    }
}
