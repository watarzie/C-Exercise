using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();// Delegate olusturan yer
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int sayi1, int sayi2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            MyDelegate myDelegate = customerManager.Add;
            myDelegate += customerManager.ShowAlert;
            myDelegate();
            MyDelegate2 myDelegate2 = customerManager.Add2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello");// kısıtlama var iki metota da delegate aynı parametreyi goturur birden fazla verilmez..
            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;//MyDelegate3 return tipi int dondurdugu deger her zaman delagetin son elemanındaki isleme tekabul eder yani son eleman carpma oldugu ıcın 2 ile 3 u carpar geri donusu en son o olur..
            myDelegate3 += matematik.Carp;
            var sonuc=myDelegate3(2, 3);
            Console.WriteLine(sonuc);
            Console.ReadLine();

        }
    }
    public class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Carefull");
        }
        public void Add2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
