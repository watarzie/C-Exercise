using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(5,7);
            //Console.WriteLine(dortIslem.Topla(3, 2));
            //Console.WriteLine(dortIslem.Topla2());

            var type = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,5,7); // Çalışma anında reflection ile dinamik bir şekilde instance üretiyoruz..
            //Console.WriteLine(dortIslem.Topla(3, 2));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type, 6, 7);
            
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null)); // önce instance degerinin tipini aldık.Cagıracagımız metodu verdik.Daha sonra invoke ederek onu calıstırdık fakat tekrardan degeri belırtmemız gerekli..
            Console.WriteLine("-----------------");
            var metod = type.GetMethods(); // type'ın barındırdığı nesnedeki metotları bir array olarak alır..
            foreach (var item in metod) // foreach ile o arrayde geziyoruz
            {
                Console.WriteLine("Metotların adı: {0}", item.Name);// gezdigimiz arrayde reflection ile calıstıgı anda metotların ısmını yani DortIslemin barındırdıgı metotların ısmını donduruyoruz...
                foreach (var parametersınfo in item.GetParameters())// burada ise metotların sahip oldugu parametreler ekrana yazdırılmak üzere işlem yapılır..
                {
                    Console.WriteLine("Parametreler: {0}", parametersınfo.Name);
                }
                foreach (var attributeinfo in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name:{0}", attributeinfo.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }
    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Çarp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetotName("Carpma")]
        public int Çarp2()
        {
            return _sayi1 * _sayi2;
        }
    }
    public class MetotNameAttribute:Attribute
    {
        public MetotNameAttribute(string name)
        {

        }
    }
}
