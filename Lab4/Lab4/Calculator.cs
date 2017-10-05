using System;

namespace Lab4
{
    public class Calculator
    {
        public static void DivideFloatingPoints(float dividend, float divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Divisor can't be 0, Thank you");
                throw new ArgumentException();
            }
            Console.WriteLine("Answer: {0}", dividend / divisor);
        } //end of static method DivideFloatingPoints
    }
}