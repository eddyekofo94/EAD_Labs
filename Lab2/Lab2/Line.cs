using System;
using System.IO;
using static Lab2.Shape;
namespace Lab2
{
    public class Line : Shape
    {
        private Vertex endPoint;
        public Line(Vertex vertex1, Vertex vertex2, String colour) : base (colour)
        {
            position = vertex1;
            endPoint = vertex2;
        }

        public override string ToString()
        {
            return string.Format("{0}\n Curent Position: {1}\n End Point {2}\n", base.ToString(), position, endPoint);
        }

        public override void Translate(int x, int y)
        {
            position.X += x;
            position.Y += y;
            
            //The end point of the vertext moves here
            endPoint.X += x;
            endPoint.Y += y;
        }
    }
}