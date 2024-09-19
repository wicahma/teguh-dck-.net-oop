using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasDay19
{
    public class Customer : User
    {
        public Customer(string nama, int money)
        {
            this.nama = nama;
            this.role = "cust";
            this.money = money;
        }

        public int getMoney() { return this.money; }
    }
}
