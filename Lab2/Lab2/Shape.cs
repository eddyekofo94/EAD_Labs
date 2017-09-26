using System;
namespace Lab2
{
    public class Shape
    {
        protected string Colour { get; set; }

        public Shape(string colour)
        {
            this.Colour = colour;
        }

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
         * 
         */

        protected int Translate(int x, int y)
        {

        }
    }
}
