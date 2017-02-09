using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program3
    {
        public static void Main()
        {
            int[] a; //a is an array of int
            a = new int[3]; //a has 3 elements
            a[0] = 1;
            a[1] = 10;
            a[2] = 100;

            int[] b = new int[3];
            b[0] = 1;
            b[1] = 10;
            b[2] = 100;
            Console.WriteLine(b[0]); //1

            b = new int[3]; //replace with a new array - old array will be thrown away with the values
            Console.WriteLine(b[0]); //0

            int[] c = new int[] { 1, 10, 100 };
            int[] d = new int[3] { 1, 10, 100 };

        }
    }
}
