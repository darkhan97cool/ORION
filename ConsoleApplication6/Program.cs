using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Complex
    {
        public int a, b;
        public Complex(int _a, int _b)
        {
            this.a = _a;
            this.b = _b;
        }
        public static Complex operator +(Complex first, Complex second)
        {
            Complex result = new Complex(first.a + second.a, first.b + second.b);
            return result;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Complex comp1 = new Complex(3, 7); //3/7
            Complex comp2 = new Complex(9, 7); //9/7
            Complex result = comp1 + comp2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

        