using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double dividend, divisor;
            string dividendIn, divisorIn;
            Console.WriteLine("Please enter the dividend");
            dividendIn = Console.ReadLine();
            
            if (Double.Parse(dividendIn, out dividend))
            {
                
            }
            
            try
            {
                Calculator.DivideFloatingPoints(2, 0);
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
                Calculator.DivideFloatingPoints(4, 2);
            
        }
    }
}