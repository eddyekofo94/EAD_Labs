using System;

namespace Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            //Vertex vtx1 = new Vertex(2, 3);

            //Shape shp = new Shape("Red");
//            Line line = new Line(new Vertex(2,3), new Vertex(3, 4), "red");
//            Console.Write(line);
//            line.Translate(2, 2);
//            
//            Console.Write(line);
            
            Circle circle = new Circle("Green", new Vertex(2, 3), 4);
            Console.WriteLine(circle);

            circle.Translate(2,3);
            Console.WriteLine("Translated\n" + circle);
        }
    }
}
