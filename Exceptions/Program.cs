using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();

            
            try
            {
                NewMethod1();
            }
            catch(RecordNotFound exception)
            {
                Console.WriteLine(exception.Message);
            }
            //yukarıdaki blokla aynı işlemi yapar..
            //handle exceptiona parametre olarak method verildi..
            // bu cok daha profesyonel kullanımdır..
            HandleException(() =>
            {
                NewMethod1();
            });
            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void NewMethod1()
        {
            List<string> students = new List<string> { "Omer", "Ahmet", "Kerem" };

            if (!students.Contains("Aygun"))
            {
                throw new RecordNotFound("Record Not found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void NewMethod()
        {
            //kod duzgun calısırsa bu blok isler
            try
            {
                string[] students = new string[3] { "Omer", "Kerem", "Ahmet" };
                students[3] = "Aygun";
            }
            //kod duzgun calısmassa hata fırlatılırsa ıstenılen ıslem bu blokta gerceklestirilir...
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }
    }
}
