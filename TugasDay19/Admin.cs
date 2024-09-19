using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasDay19
{
    public class Admin : User
    {
        public Admin()
        {
            this.nama = "Teguh Dwi Cahya";
            this.role = "admin";
            this.money = 0;
        }

        public void custMoney(Customer customer, int custMoney)
        {
            customer.money += custMoney;
        }
    }
}
