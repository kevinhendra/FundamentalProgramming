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
            String inputStg = "";
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
                                Console.Write("Masukkan Diagonal 1 : ");
                                int d1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan Diagonal 2 : ");
                                int d2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan rusuk 1 : ");
                                int rusuk1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan rusuk 2 : ");
                                int rusuk2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Luas : " + (0.5 * d1 * d2));
                                Console.WriteLine("Keliling : " + (2 * (rusuk1 + rusuk2)));
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.Write("Masukkan panjang : ");
                                int panjang = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan Luas: ");
                                int lebar = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Luas : " + (panjang * lebar));
                                Console.WriteLine("Keliling : " + (2 * (panjang * lebar)));
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStg = Console.ReadLine();
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            catch (System.DivideByZeroException e)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            break;
                        case 3:
                            try
                            {
                                Console.Write("Panjang Diagonal 1 : ");
                                int d1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Panjang Diagonal 2 : ");
                                int d2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan Sisi : ");
                                int sisi = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Luas : " + (0.5 * d1 * d2));
                                Console.WriteLine("Keliling : " + (4 * sisi));
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            break;
                        case 4:
                            try
                            {
                                Console.Write("Masukkan sisi atas : ");
                                int atas = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan sisi bawah :");
                                int bawah = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan tinggi :");
                                int tinggi = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan sisi samping :");
                                int samping = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Luas : " + 0.5 * (atas + bawah) * tinggi);
                                Console.WriteLine("Keliling : " + (bawah + samping + atas + samping));
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            break;
                        case 5:
                            try
                            {
                                Console.Write("Masukkan Alas :");
                                int alas = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan tinggi :");
                                int tinggi = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Masukkan Sisi: ");
                                int sisi = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Luas : " + alas * tinggi);
                                Console.WriteLine("Keliling : " + 2*(alas+sisi));
                                Console.Write("Hitung lagi? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.Write("input yang dimasukkan salah. Ulang? (y/n) ");
                                inputStg = Console.ReadLine();
                            }
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.Write("Inputan Salah. Ulang? (y/n) ");
                    inputStg = Console.ReadLine();
                }
            } while (inputStg.Equals("y") || inputStg.Equals("Y"));
        }
    }
}
