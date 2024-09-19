using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebakanAngka
{
    internal class Tebak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Tebak Tebakan Angka ======");

            Random rnd = new Random();
            
            int randomNumber = rnd.Next(1, 10);
            int userNumber = 0;
            int userTry = 0;
            bool isUserWin = false;

            while (!isUserWin) {
                userTry++;
                Console.Write("Masukkan angka : ");
                String? inputUser = Console.ReadLine();
                userNumber = Int32.Parse(inputUser);

                if (userNumber == randomNumber)
                {
                    isUserWin = true;
                    Console.WriteLine("Benar");
                }
                else
                {
                    isUserWin = false;
                    Console.WriteLine("Salah");
                }
            }
            Console.WriteLine($"Angka Randomnya adalah {randomNumber}");
            Console.WriteLine($"Total percobaan {userTry}");

        }
    }
}
