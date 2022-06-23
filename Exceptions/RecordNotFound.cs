using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    //kendi hata sınıfımızı exception classından inherit ederek oluşturduk
    public class RecordNotFound:Exception
    {
        //constructor message parametresini base classa yolladı.
        public RecordNotFound(string message):base(message)
        {

        }
    }
}
