using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program5
    {
        public static void Main()
        {
            int[,] Marks = new int[,] { { 10, 20, 30, 40 }, 
                                        { 40, 50, 60, 70 }, 
                                        { 70, 80, 90, 100 } };
             
            string[] StudentName = new string[3]
                                     {"Venkat", "John", "Sabina"}; // only 3 elements

            //double ClassAvg;

            //ClassAvg = (Marks[0] + Marks[1] + Marks[2]) / 3.0;
             
            for (int i = 0; i < StudentName.Length; i++)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", i, StudentName[i], Marks[i,0],
                    Marks[i,1], Marks[i,2]);

            Console.WriteLine("Marks.Length = {0}", Marks.Length); //12
            Console.WriteLine("Marks.GetLength(0) = {0}", Marks.GetLength(0)); //3
            Console.WriteLine("Marks.GetLength(1) = {0}", Marks.GetLength(1)); //4
            //Console.WriteLine("Average Marks for Class is {0}", ClassAvg);

            Console.WriteLine("Marks[1,2] = {0}", Marks[1, 2]); //60
            //Console.WriteLine(Marks[1]);


        }
    }
}
