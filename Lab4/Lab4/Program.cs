using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Calculator.DivideFloatingPoints(2, 0);
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
                Calculator.DivideFloatingPoints(4.5, 2);
            
        }
    }
}