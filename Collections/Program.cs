using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<customerManager> customer = new List<customerManager>
            {
                new customerManager{id=1,FirstName="Ömer"},
                new customerManager{id=2,FirstName="Kerem" }
            };
            foreach (var item in customer)
            {
                Console.WriteLine(item.id);
            }
            

            Console.ReadLine();
        }
    }
    class customerManager
    {
        public int id { get; set; }
        public string FirstName { get; set; }
    }
}
