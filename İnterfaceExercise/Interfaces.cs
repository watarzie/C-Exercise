using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceExercise
{
    interface ICustomerDal
    {
        void Add();
        void Uptade();
        void Delete();

    }
    class MySqlServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Deleted");
        }

        public void Uptade()
        {
            Console.WriteLine("Sql Server Uptaded");
        }
    }
    class OracleServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Server Deleted");
        }

        public void Uptade()
        {
            Console.WriteLine("Oracle Server Uptaded");
        }
    }
    class DataBaseManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
        }
        public void Delete(ICustomerDal customer)
        {
            customer.Delete();
        }
    }
}
