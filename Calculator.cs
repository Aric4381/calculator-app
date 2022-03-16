using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.WriteLine("Pilih Menu Kalkulator: ");

            Console.WriteLine();

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine();

            Console.Write("Input nomor menu: ");
            int i = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                Console.WriteLine();

                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
            }
            else if (i == 2)
            {
                Console.WriteLine();

                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (i == 3)
            {
                Console.WriteLine();

                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (i == 4)
            {
                Console.WriteLine();

                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("\nMaaf, menu yang anda pilih tidak tersedia");
                Console.ReadKey();
            }

            Console.WriteLine();

            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}