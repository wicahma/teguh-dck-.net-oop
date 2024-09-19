using System;
namespace UserManagement
{
    class User
    {
        // Attribut
        string nama = "Teguh Dwi Cahya Kusuma";
        string role = "CTO";
        int e_money = 1_000_000_000;
        
        // Method
        public void UserDetail()
        {
            Console.WriteLine("Ini detail user \n");
        }

        // Object
        static void Main(string[] args)
        {
            // Kelas adalah blueprint dari 
            User userBootcamp = new User();
            userBootcamp.UserDetail();
            Console.WriteLine($"Nama    : {userBootcamp.nama}");
            Console.WriteLine($"Role    : {userBootcamp.role}");
            Console.WriteLine($"E-Money : {userBootcamp.e_money}");
        }
    }

}