using System;
namespace Lab2
{
    public class Vertex
    {
        public Vertex(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        // default constructor
        public Vertex()
        {
        }

        // 3.    Implement appropriate properties for the class.
		public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return string.Format("x: {0} , y: {1}", X, Y);
        }
    }
}
