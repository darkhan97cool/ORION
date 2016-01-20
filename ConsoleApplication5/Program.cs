using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            nt secondplayed = 100;
            const int perminutes = 60;
            int minutes = secondplayed / perminutes;
            int seconds = secondplayed % perminutes;
            Console.WriteLine("Minutes " + minutes);
            Console.WriteLine("Seconds " + seconds);
            Console.ReadKey();
        }
    }
}
