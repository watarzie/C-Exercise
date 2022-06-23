using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmit", "İstanbul");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Ömer" },new Customer {FirstName="Kerem" });
            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items) // Generic Metot
        {
            return new List<T>(items);
        }
    }
    class Product:IEntity
    {

    }
    interface IProductDal:IRepository<Product>
    {

    }
    interface ICustomerDal:IRepository<Customer>
    {
        void Custom();
    }
    class Customer:IEntity
    {
        public string FirstName { get; set; }
    }
    class Student:IEntity
    {

    }
    interface IEntity
    {

    }
    interface IStudentDal : IRepository<Student>
    {

    }
    interface IRepository<T> where T:class,IEntity,new() // generic kısıtlar--> gelen tip referans tipinde IEntity interface barındıran ve newlenebilen yani nesne oluştulabilien tipte olmalı..
                                                         //class referans tip alması için value type istese idik struct yazabilirdik..
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IRepository<Product>.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Product> IRepository<Product>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal

    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom() //CustomerDal için özel bir operasyon,bundan sebeble Irepository implemantasyonu yapılmadı ıcustomer yapıldı.
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        Customer IRepository<Customer>.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Customer> IRepository<Customer>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
