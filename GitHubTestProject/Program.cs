﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubTestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github!");
            Console.WriteLine("Please complete the following functions and initate a pull request.");
        }

        /// <summary>
        /// Tests if a given number is a prime
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(int n)
        {
            if (n == 2)
                return true;
            for (int i = 3; i < n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return n % 2 != 0;
        }

        /// <summary>
        /// Sorts a given integer array
        /// </summary>
        /// <param name="a">An integer array</param>
        public static void Sort(int[] a)
        {
            Array.Sort(a);
            // TODO: Complete fhe funtion
        }
    }
}
