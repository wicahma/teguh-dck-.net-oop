using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarLINQ
{
    internal class BelajarLINQ
    {
        static void Main(string[] args)
        {
            string[] bootcamp =
                {
            "teguh", "ilham", "udin", "reyhan", "saphir"
            };

            var query = from n in bootcamp select n;

            foreach (var item in query) {
                Console.WriteLine(item);
            }

            List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };

            var queryNumber = from n in numbers where n > 2 && n < 13 orderby n descending select n;
            foreach (var item in queryNumber)
            {
                Console.WriteLine(item);
            }

        }
    }
}
