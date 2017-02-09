using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program2
    {
        public static void Main()
        {
            //ask for input
            Console.Write("Enter a matriculation number: ");
            string input = Console.ReadLine();

            //if (not 7 characters)
            if (input.Length != 7)
            {
                //invalid
                Console.WriteLine("Invalid");
            }
            else
            {
                //else
                //convert input into uppercase
                input = input.ToUpper();

                //calculate checksum
                int sum = 0;

                for (int i = 1; i <= 5; i++)
                {
                    sum = sum + (Convert.ToInt32(input.Substring(i, 1)) * (7-i));
                }

                //calculate the sum - calculated in variable sum
                //divide by 5 and get the remainder
                int remainder = sum % 5;

                //int remainder = ((d1*6) + (d2*5) + (d3*4) .. ) % 5;

                //map the remainder to the checksum
                string checksum="";
                switch (remainder)
                {
                    case 0:
                        checksum = "O";
                        break;
                    case 1:
                        checksum = "P";
                        break;
                    case 2:
                        checksum = "Q";
                        break;
                    case 3:
                        checksum = "R";
                        break;
                    case 4:
                        checksum = "S";
                        break;
                }

                //if last char matches checksum then
                string lastChar = input.Substring(6, 1);
                if (lastChar == checksum)
                {
                    //valid
                    Console.WriteLine("Valid");
                }
                else
                {
                    //else
                    //invalid
                    Console.WriteLine("Invalid");

                }

            }


        }
    }
}
