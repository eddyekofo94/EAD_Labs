using System;
using System.IO;
using static Lab2.Shape;

namespace Lab2
{
    public class Line : Shape
    {
        private Vertex EndPoint { get; }
        
        //constructor
        public Line(Vertex position, Vertex vertex2, String colour) : base(colour, position)
        {
            Console.WriteLine("Line created");
            EndPoint = vertex2;
        }

        public override string ToString()
        {
            return string.Format("{0}\n Curent Position: {1}\n End Point {2}\n", base.ToString(), Position, EndPoint);
        }

        public override void Translate(int x, int y)
        {
            Position.X += x;
            Position.Y += y;

            EndPoint.X += x;
            EndPoint.Y += y;
        }
    }
}