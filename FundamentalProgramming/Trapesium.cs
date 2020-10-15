using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalProgramming
{
    class Trapesium
    {
        private float atas, bawah, tinggi, samping;
        public void inputTrapesium()
        {
            Console.Write("Masukkan sisi atas : ");
            atas = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan sisi bawah :");
            bawah = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan tinggi :");
            tinggi = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan sisi samping :");
            samping = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Luas : " + Math.Round((0.5 * (atas + bawah) * tinggi),2));
            Console.WriteLine("Keliling : " + Math.Round((bawah + samping + atas + samping),2));
        }
    }
}
