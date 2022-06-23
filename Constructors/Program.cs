using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager(23);
            customer.List();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)//parametreli consturctor
        {
            _count = count;
        }
        // yapıcılar overload edildi...
        public CustomerManager()//default consturctor
        {
                
        }
        public void List()
        {
            Console.WriteLine("Listed {0}",_count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
}
