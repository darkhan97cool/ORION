using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;

        }
        
        public static Complex operator +(Complex c1, Complex c2)
        {
            if (c1.b == c2.b)
            {
                Complex sum1 = new Complex(c1.a + c2.a, c1.b);
                return sum1;
            }
            else
            {
                Complex sum = new Complex(c1.a * c2.b + c1.b * c2.a, c1.b * c2.b);
                return sum;
            }
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
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string[] c1 = A.Split('/');
            string[] c2 = B.Split('/');
            Complex sum2 = new Complex(int.Parse(c1[0]), int.Parse(c1[1]));
            Complex totalsum = new Complex(int.Parse(c2[0]), int.Parse(c2[1]));
            Complex jauab = sum2 + totalsum;
            Console.WriteLine(jauab);
            Console.ReadKey();
        }
    }
}