﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


  

        class Program
        {
            static void Main(string[] args)
            {
              Console.WriteLine("Enter a number:");
              double num1 = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("Enter Oparator");
              string op = Console.ReadLine();

              Console.WriteLine("Enter a number:");
              double num2 = Convert.ToDouble(Console.ReadLine());
              
              if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }else if(op == "*")
            {
                Console.WriteLine(num1 * num2);
            }else
            {
                Console.WriteLine("Invalid Operator");
            }


            Console.ReadLine();

            }
   

        }
   
}

  
    