using System;

namespace Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Vertex vtx = new Vertex(2, 3);
            Console.Write(vtx);

            Shape shp = new Shape("Red");

            Console.Write(shp);
        }
    }
}
