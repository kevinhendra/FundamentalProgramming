using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalProgramming
{
    class Jajar_genjang
    {
        private float alas, tinggi, sisi;
       public void inputJajarGenjang()
        {
            Console.Write("Masukkan Alas :");
            alas = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan tinggi :");
            tinggi = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan Sisi: ");
            sisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas : " + alas * tinggi);
            Console.WriteLine("Keliling : " + 2 * (alas + sisi));
        }
    }
}
