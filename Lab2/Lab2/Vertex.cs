using System;
namespace Lab2
{
    public class Vertex
    {
        //protected int x, y; //Variables
        public Vertex(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

		//3.    Implement appropriate properties for the class.
		protected int X { get; set; }
        protected int Y { get; set; }

        public override string ToString()
        {
            return string.Format("Vertex:\n x: " + X + " y: " + Y);
        }
    }
}
