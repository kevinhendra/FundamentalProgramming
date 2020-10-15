using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalProgramming
{
    
    class Persegi_panjang
    {

        private float panjang, lebar;
        public void inputPersegiPanjang()
        {
            Console.Write("Masukkan panjang : ");
            panjang = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan Luas: ");
            lebar = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Luas : " + (panjang * lebar));
            Console.WriteLine("Keliling : " + (2 * (panjang * lebar)));
        }
    }
}
