using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                LastName = "Akkaya",
                Age = 22

            };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();

        }
    }
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [Requiredproperty]
        public string FirstName { get; set; }
        [Requiredproperty]
        public string LastName { get; set; }
        [Requiredproperty]
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Dont use Add instead use Add2")]// hazır bir attribute kullancıya Add metodunu kullanma Add2 yi kullan diyen bir çağrı döndürür..
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void Add2(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)] // bu attribute sınıfını sadece özellikler için aktif et anlamına gelir.Allowmultiple kullanılarak ise fazladan kullanılması engellenir yada serbest bırakılır...
    class RequiredpropertyAttribute:Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]//bu attribute ise sadece sınıflarda aktif edilebilir anlamındadır..
    class ToTableAttribute:Attribute
    {
        string _toTable;
        public ToTableAttribute(string tablename)
        {
            _toTable = tablename;
        }
    }
}
