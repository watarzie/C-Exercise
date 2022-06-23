using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseManager manager = new DataBaseManager();
            manager.Add(new OracleServer());
            manager.Delete(new MySqlServer());

            Console.ReadLine();
        }
    }
}
