using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            customermanager.Add();
            customermanager.Uptade();

            ProductManager productmanager = new ProductManager();

            productmanager.Add();
            productmanager.Uptaded();

            Customer customer = new Customer();

            customer.FirstName = "Ömer";
            customer.Id = 1;
            customer.LastName = "Akkaya";

            Customer customer2 = new Customer
            {
                FirstName = "Kerem",
                Id = 2,
                LastName = "Akkaya"
            };
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.Id);

            Console.ReadLine();
        }
    }
}
