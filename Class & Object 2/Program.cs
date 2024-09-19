using System;

namespace UserBootcamp
{

    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp11 _userBootcamp = new UserBootcamp11();
            _userBootcamp.namaUser = "Teguh Dwi Cahya Kusuma";
            Console.WriteLine($"Nama {_userBootcamp.namaUser}");
        }
    }
    public class UserBootcamp11
    {
        string nama;
        string role;
        int e_money;

        // cara mudahnya
        public string namas { get; set; }

        public string namaUser
        {
            get
            {
                return nama;
            }
            set {
                nama = value;
            }
        }
        public string roleUser
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        public int emoneyUser
        {
            get
            {
                return e_money;
            }
            set
            {
                e_money = value;
            }
        }
    }
}