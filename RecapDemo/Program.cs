using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager(new DatabaseLogger());//parametre olarak database logu verildi..
            
            customer.Add();

            Console.ReadLine();

        }
    }
    interface Ilogger
    {
        void Log();
    }
    class CustomerManager
    {
        private Ilogger _logger;
        public CustomerManager(Ilogger logger)//kurucu fonskıyon parametre olarak ınterface turunden logger aldı ve ıslemı gerceklestırdı...
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Customer Added");
        }
    }
    class DatabaseLogger:Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
    class FileLogger:Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
}
