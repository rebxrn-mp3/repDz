﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zad4
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());


            int maxDigit = 0;
            int minDigit = 9;


            while (number > 0)
            {
                int digit = number % 10;


                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
                if (digit < minDigit)
                {
                    minDigit = digit;
                }

                number /= 10;
            }

            Console.WriteLine($"Максимальная цифра: {maxDigit}");
            Console.WriteLine($"Минимальная цифра: {minDigit}");

            Console.ReadKey();
        }
    }
}