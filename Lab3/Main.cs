using System;
using System.Collections.Generic;
//Using the dotnet framework methods


namespace Lab3
{
    internal class MainClass //: Object (You don't have to specify the parent class)
    {
        public static void Main(string[] args)
        {
            /*
             * Test the class. Call the method to calculate the volume of a 
             * sphere polymorphically. Display details of the sphere object. 
             * Make a collection of spheres and call various methods on each sphere

             */

            //Instance of sphere.
            ThreeDShape sphere1 = new Sphere(7, "Sphere 1");

            //Instance of sphere
            ThreeDShape sphere2 = new Sphere(4, "Sphere 2");

            try
            {
                ThreeDShape sphere3 = new Sphere(-1, "Sphere 3");
            }
            catch (ArgumentException ex)
            {
                Console.Write(ex + "Error, the radius must be a positive number\n");
            }


            //Creates a list of shapes
            var shapes = new List<ThreeDShape>();

            //Adds the spheres
            shapes.Add(sphere1);
            shapes.Add(sphere2);

            foreach (object s in shapes)
                Console.Write(s);
            //Console.WriteLine(sphere);
        }
    }
}