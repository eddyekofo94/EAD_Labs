namespace Lab2
{
    public class Shape
    {
        public Vertex position;

        public Shape(string colour)
        {
            Colour = colour;
        }

        protected string Colour { get; set; }

        // The ToString
        public override string ToString()
        {
            return string.Format("Shape:\nColour: " + Colour);
        }

        /*
         * ToString should be straight forward enough.
         * Translation means move, the Shape has x and y coordinates, 
         * to translate it means changing these coordinates to move the Shape                        

           If shape.position is (3,4), then shape.
           translate(2,-2) would make it : shape.position (5,2)
         */

        public virtual void Translate(int x, int y)
        {
            position.X += x;
            position.Y += y;
        }
    }
}