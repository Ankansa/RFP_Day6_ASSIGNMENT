﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_ASSIGNMENT
{
    internal class Fibonacci
    {
        public void fibonacciMethod(int Input)
        {
        
            int Num1 = 0, Num2 = 1,Num3;
            Console.Write(Num1 + " " + Num2 + " " );
            for(int i = 2; i < Input; i++)
            {
                Num3 = Num1 + Num2;
                Num1 = Num2;
                Num2 = Num3;
                Console.Write(Num3 + " ");
            }
            Console.WriteLine();
        }
    }
}
