﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter details N/m and numbers.");
            string sInputLine1 = Console.ReadLine();
            string sInputLine2 = Console.ReadLine();


            string[] sArrayInput1 = sInputLine1.Trim().Split(' ');
            int iArraySize = 0;
            int iSearchIteam = 0;

            if (sArrayInput1.Length != 2)
            {
                Console.WriteLine("Please enter only two numbers in first line seperated by space.");
                Console.ReadKey();
                return;
            }
            if (!int.TryParse(sArrayInput1[0], out iArraySize))
            {
                Console.WriteLine("Invalid array size entered. Please correct.");
                Console.ReadKey();
                return;
            }
            else if (iArraySize < 1 || iArraySize > 100000)
            {
                Console.WriteLine("Array size must be in the range of 1 to 100000. Please correct.");
                Console.ReadKey();
                return;
            }

            if (!int.TryParse(sArrayInput1[1], out iSearchIteam))
            {
                Console.WriteLine("Invalid search element entered. Please enter numeric search element between 1 to 1000000000.");
                Console.ReadKey();
                return;
            }
            else if (iSearchIteam < 1 || iSearchIteam > Math.Pow(10, 9))
            {
                Console.WriteLine("Array size must be in the range of 1 to 1000000000 [power(10,9)]. Please correct.");
                Console.ReadKey();
                return;
            }

            string[] sArrayElements = sInputLine2.Split(' ');
            if (sArrayElements.Length != iArraySize)
            {
                Console.WriteLine("Array size provided and elementes entered don's match.");
                Console.ReadKey();
                return;
            }

            int[] iArrayElements = new int[iArraySize];
            int index = -1;
            for (int i = 0; i < sArrayElements.Length; i++)
            {
                if (!int.TryParse(sArrayElements[i], out iArrayElements[i]))
                {
                    Console.WriteLine("Invlid number entered: {0}  Please correct.", sArrayElements[i]);
                    Console.ReadKey();
                    return;
                }
                else if (iSearchIteam == iArrayElements[i])
                {
                    index = i+1;
                }
            }
            Console.WriteLine("{0}", index);
            Console.ReadKey();//Checkin in developer branch
        }

        private static int[] ValidateLine1(string sInputLine1)
        {
            throw new NotImplementedException();
        }
    }
}
