﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2();
            //int number1;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.WriteLine(result);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 35));

            Console.ReadLine();
        }

        //static void Add()
        //{
            //Console.WriteLine("Added!");
        //}


        //static int Add2(int number1 = 22, int number2 = 35)
        //{ 
            //var result = number1 + number2;
            //return result;
        //}

        //static int Add3(out int number1, int number2)
        //{
            //number1 = 30;

            //return number1 + number2;
        //}

        static int Multiply(int number1, int number2)

        {

             return number1 * number2 ;

        }

        static int Multiply(int number1, int number2, int number3)

        {

             return number1 * number2 * number3 ;

        }
    }
}
