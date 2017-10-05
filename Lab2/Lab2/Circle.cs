using System;

namespace Lab2
{
    public class Circle : Shape
    {
        //private Vertex Vertex { get; set; }
        private int Radius { get; set; }

        public Circle(string colour, Vertex position, int radius) : base(colour, position)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return string.Format("{0}\n Position: {1}\n Radius: {2}\nArea: {3}", base.ToString(), Position, Radius, Area());
        }
        
        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2),2);
        }
}
}