using System;

namespace Lab2
{
    public class Circle : Shape
    {
        private Vertex Vertex { get; set; }
        private int Radius { get; set; }
        private Vertex endPoint { get; set; }

        public Circle(string colour, Vertex vertex, int radius) : base(colour)
        {
            Vertex = vertex;
            Radius = radius;
        }

        public override string ToString()
        {
            return string.Format("{0}\n Points: {1}\n Radius: {2}", base.ToString(), Vertex, Radius);
        }

        public override void Translate(int x, int y)
        {
            position.X = x;
            position.Y = y;

            endPoint.X = x;
            endPoint.Y = y;
        }

        public double Area()
        {

        private double result;
            return result = Math.PI* Math.Pow(Radius, 2);
    }
}

}