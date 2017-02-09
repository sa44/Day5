using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program4
    {
        public static void Main()
        {
            int[] Marks = new int[5]; //we create array of int with 5 elements
            string[] StudentName = new string[3]
                                     {"Venkat", "John", "Sabina"}; // only 3 elements

            double ClassAvg;
            Marks[0] = 35;
            Marks[1] = 82;
            Marks[2] = 67;
            ClassAvg = (Marks[0] + Marks[1] + Marks[2]) / 3.0;
             
            for (int i = 0; i < StudentName.Length; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, StudentName[i], Marks[i]);

            Console.WriteLine("Average Marks for Class is {0}", ClassAvg);


        }
    }
}
