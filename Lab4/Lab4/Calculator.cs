using System;

namespace Lab4
{
    public class Calculator
    {
        public float NumberToBeDevided { get; set; }
        private float _numberThatDevides;

        public Calculator()
        {
            
        }
        
        public float NumberThatDevides
        {
            get => _numberThatDevides;
            set
            {
            if (_numberThatDevides == 0)
            {
                Console.WriteLine("Can't devide by 0");
                throw new ArgumentException();
            }

            return NumberToBeDevided = numberIn;
                
            }
        }
        
    }
}