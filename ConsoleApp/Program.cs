using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Sugeng rawuh!");
            MstProduct product = new MstProduct();
            product.Name = "Teguh Dwi Cahya Kusuma";
            product.Description = "Ini adalah contoh dari deskripsi dari class yang di include pada csharp";

            Console.WriteLine($"Nama orang : {product.Name}");
            Console.WriteLine($"Deskripsi dari kelas : {product.Description}");

            Console.Write("Masukkan angka pertama : ");
            String? inputA = Console.ReadLine();
            Console.Write("Masukkan angka kedua : ");
            String? inputB = Console.ReadLine();

            int a;
            int b;

            bool isAParsed = Int32.TryParse(inputA, out a);
            bool isBParsed = Int32.TryParse(inputB, out b);

            if (isAParsed)
            {
                Console.WriteLine("Input A is not a valid Number!");
                return;
            }
            if (isBParsed)
            {
                Console.WriteLine("Input B is not a valid Number!");
                return;
            }

            int sum = a + b;
            Console.WriteLine($"Hasil dari A + B = {sum}");


            int bakwan = 0;
            int nasgor = 0;
            int bakpia = 0;
            int gorengan = 0;

            String? isStop = Console.ReadLine();

            do
            {
                String? sw = Console.ReadLine();
                switch (sw)
                {
                    case "bakwan":
                        Console.WriteLine("Anda telah berhasl mendapatkan 1 bakwan");
                        bakwan += 1;
                        break;
                    case "nasgor":
                        Console.WriteLine("Anda telah berhasl mendapatkan 1 nasgor");
                        nasgor += 1;
                        break;
                    case "bakpia":
                        Console.WriteLine("Anda telah berhasl mendapatkan 1 bakpia");
                        bakpia += 1;
                        break;
                    case "gorengan":
                        Console.WriteLine("Anda telah berhasl mendapatkan 1 gorengan");
                        gorengan += 1;
                        break;
                    default:
                        Console.WriteLine("Anda tidak mendapatkan apa apa");
                        Console.Write("Apakah anda ingin berhenti? y/n");
                        isStop = Console.ReadLine();
                        break;
                }
            }
            while (isStop == "n");

            Console.WriteLine("Program telah selesai!");
            Console.WriteLine("=== Anda telah berhasil mendapatkan");
            Console.WriteLine($"{gorengan} Gorengan");
            Console.WriteLine($"{bakwan} bakwan");
            Console.WriteLine($"{nasgor} nasgor");
            Console.WriteLine($"{bakpia} bakpia");

        }
    }
}