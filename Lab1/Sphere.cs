using System;

namespace Lab1
{
    public class Sphere : ThreeDShape
    {
        //Variables
        /* 2. The class should have field to store the radius of the sphere, 
         * and a read-write property corresponding to the field.
         * The radius must be always positive.
         */
        protected int Radius { get; set; }

        //3. Implement appropriate constructors for the class.
        public Sphere(int Radius, string type) : base(type)
        {
            this.Radius = Radius;
        }

        public override double Volume()
        {
            double result = Math.PI * Math.Pow(this.Radius, 3);

            return Math.Round(result, 2);   //Rounds the number by 2 decimal places
        }

        /*
         * 
         * 5. Override the ToString() method inherited from ThreeDShape, 
         * make it display information about the sphere.
         */
        public override string ToString()
        {
            return string.Format(base.ToString() + "\nRadius: " + this.Radius + "\n");
        }
    }
}
