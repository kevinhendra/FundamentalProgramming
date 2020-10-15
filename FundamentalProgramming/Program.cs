using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FundamentalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int k = 0;
             Console.Write("Bilangan Prima : ");
             for (int i = 1; i <= input; i++)
             {
                 for (int j = 1; j < i; j++)
                 {
                     if (i % j == 0)
                     {
                         k++;
                     }
                 }
                 if (k < 2)
                 {
                     Console.Write(i + ", ");
                 }
             }
             Console.WriteLine();
             Console.Write("Angka Ganjil : ");
             for (int i = 0; i <= input; i++)
             {
                 if (i % 2 == 1)
                 {

                     Console.Write(i + ", ");
                 }
             }
             Console.WriteLine();
             Console.Write("Angka Genap : ");
             for (int i = 0; i < input; i++)
             {
                 if (i % 2 == 0)
                 {

                     Console.Write(i + ", ");
                 }
             }
             Console.WriteLine();
             Console.WriteLine("Fibonnacci");
             int x = 0, y = 1, z;
             for (int i = 0; i < input; i++)
             {
                 Console.Write(x + " ");
                 z = x + y;
                 x = y;
                 y = z;
             }*/

            /* for (int i = 1; i <= input; i++)
             {
                 if ((i % 3 == 0) && (i % 5 == 0))
                 {
                     Console.Write("Fizzbuzz ");
                 }
                 else if(i%5 == 0)
                 {
                     Console.Write("Buzz ");
                 }
                 else if(i % 3 == 0)
                 {
                     Console.Write("Fizz ");
                 }
                 else
                 {
                     Console.Write(i + " ");
                 }
             }
             Console.WriteLine();*/

            /*for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } //segitiga siku kiri*/
            /* for (int i = 0; i < input; i++)
             {
                 for (int j = i; j < input; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             } //segitiga siku kiri terbalik*/
            /*for (int i = 1; i < input; i++)
            {
            for (int j = 0; j < input; j++)
            {
             Console.Write("*");
            }
            Console.WriteLine();
        }//persegi*/
            Layang layang = new Layang();
            Persegi_panjang persegi_Panjang = new Persegi_panjang();
            Belah_ketupat belah_Ketupat = new Belah_ketupat();
            Trapesium trapesium = new Trapesium();
            Jajar_genjang jajar_Genjang = new Jajar_genjang();
            String inputStrg = "";
            do
            {
                try
                {
                    Console.Write("Luas Bangun Datar (1.Layang-Layang 2.Persegi Panjang 3.Belah Ketupat 4.trapesium 5.Jajar Genjang) : ");
                    int inputHitung = Convert.ToInt32(Console.ReadLine());

                    switch (inputHitung)
                    {
                        case 1:
                            try
                            {
                                layang.inputLayang();
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            break;
                        case 2:
                            try
                            {
                                persegi_Panjang.inputPersegiPanjang();
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            break;
                        case 3:
                            try
                            {
                                belah_Ketupat.inputBelahKetupat();
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            break;
                        case 4:
                            try
                            {
                                trapesium.inputTrapesium();
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            break;
                        case 5:
                            try
                            {
                                jajar_Genjang.inputJajarGenjang();
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStrg = Console.ReadLine();
                            }
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.Write("Inputan Salah. Ulang? (y/n) ");
                    inputStrg = Console.ReadLine();
                }
            } while (inputStrg.Equals("y") || inputStrg.Equals("Y"));
        }
    }
}
