using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Customer{FirstName="Omer"}, new Student { FirstName = "Ahmet" }, new Person { FirstName = "Aygun" }
            };

            foreach (var item in person)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
    class Customer:Person
    {
        public string Department { get; set; }
    }
    class Student:Person
    {
        public string City { get; set; }
    }
}
