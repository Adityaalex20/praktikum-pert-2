using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace kalkulator
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            Console.WriteLine("Silahkan Pilih Menu ");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine("\n");
            Console.Write("input menu [1-4] : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            if (input > 4 || input == 0) Console.WriteLine("Maaf menu yang anda pilih tidak tersedia");

            switch (input)
            {
                case 1:
                    penambahan();
                    Console.ReadKey();
                    break;
                case 2:
                    pengurangan();
                    Console.ReadKey();
                    break;
                case 3:
                    perkalian();
                    Console.ReadKey();
                    break;
                case 4:
                    pembagian();
                    Console.ReadKey();
                    break;
            }


        }
        static void penambahan()
        {
            Console.Clear();
            Console.WriteLine("Penjumlahan");
            Console.Write("Nilai A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int hasil = a + b;
            Console.WriteLine("Hasil Dari " + a + " + " + b + " = " + hasil);

        
        }
        static void pengurangan()
        {
            Console.Clear();
            Console.WriteLine("Pengurangan");
            Console.Write("Nilai A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int hasil = a - b;
            Console.Write("Hasil Dari " + a + " - " + b + " = " + hasil);
        }
        static void perkalian()
        {
            Console.Clear();
            Console.WriteLine("Perkalian");
            Console.Write("Nilai A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int hasil = a * b;
            Console.WriteLine("Hasil Dari " + a + " x " + b + " = " + hasil);
        }
        static void pembagian()
        {
            Console.Clear();
            Console.WriteLine("Pembagian");
            Console.Write("Nilai A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nilai B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int hasil = a / b;
            Console.WriteLine("Hasil Dari " + a + " / " + b + " = " + hasil);
        }
        
        // todo: penambahan method untuk perkalian dan pembagian
    }





}
