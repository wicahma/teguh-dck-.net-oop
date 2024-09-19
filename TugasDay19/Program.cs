using System;

namespace TugasDay19
{
    public class Tugas
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();

            Customer cust1 = new Customer("teguh", 12_000);
            Customer cust2 = new Customer("cahya", 14_000);
            Console.WriteLine("Aplikasi ===");
            bool isPlay = true;
            while (isPlay)
            {
                Console.Write("Masukkan Role (cust/admin): ");
                String? role = Console.ReadLine();
                if (role != null)
                {
                    if (role == "admin")
                    {
                        Console.Write("Pilih customer (teguh/cahya) : ");
                        String? selectCustomer = Console.ReadLine();

                        if (selectCustomer.Equals(cust1.nama))
                        {
                            Console.Write($"Uang User: {cust1.getMoney()}\n");

                            Console.Write("Masukkan uang yang akan ditambahkan: ");
                            String money1 = Console.ReadLine();

                            admin.custMoney(cust1, int.Parse(money1));
                            Console.Write($"Uang User: {cust1.getMoney()}\n");
                        }
                        else if (selectCustomer.Equals(cust2.nama))
                        {
                            Console.Write($"Uang User: {cust2.getMoney()}\n");

                            Console.Write("Masukkan uang yang akan ditambahkan: ");
                            String money2 = Console.ReadLine();

                            admin.custMoney(cust2, int.Parse(money2));
                            Console.Write($"Uang User: {cust2.getMoney()}\n");
                        }
                        else
                        {
                            Console.Write("Customer Tidak ada!");
                        }
                    }
                    else if (role == "cust")
                    {
                        Console.Write("Pilih user (teguh/cahya) : ");
                        String custName = Console.ReadLine();

                        if (custName != null)
                        {
                            if (custName.Equals(cust1.nama))
                            {
                                Console.WriteLine($"Saldo User: {cust1.getMoney()}");
                            }
                            else if (custName.Equals(cust2.nama))
                            {
                                Console.WriteLine($"Saldo User: {cust2.getMoney()}");
                            }
                            else
                            {
                                Console.WriteLine("Customer Tidak ada!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Customer tidak boleh null!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Role salah!");
                }
                Console.Write("Ingin ulangi? y/n = ");
                String playAgain = Console.ReadLine();
                isPlay = (playAgain == "y") ? true : false;
            }
        }
    }
}