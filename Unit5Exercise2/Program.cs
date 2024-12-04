﻿using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danh sach so nguyen to nho hon 100:");
            for (int i = 2; i < 100; i++)
            {
                bool isPrimeNumber = true;
                for (double j = 2.0; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                    }
                }

                if (isPrimeNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
