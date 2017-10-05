using System;

namespace Lab3_Finished
{
    public class Sphere : ThreeDShape
    {
        //Variables
        /* 2. The class should have field to store the radius of the sphere, 
         * and a read-write property corresponding to the field.
         * The radius must be always positive.
         */
        private int _radius;

        //3. Implement appropriate constructors for the class.
        public Sphere(int radius, string type) : base(type)
        {
            Radius = radius;
        }

        public int Radius
        {
            get => _radius;
            set
            {
                try
                {
                    if (value <= 0)
                        throw new ArgumentException();
                    Console.Write("Error, the radius must be a positive number\n");
                  
                }
                catch (ArgumentException exception)
                {
                    Console.Write(exception + "Error, the radius must be a positive number\n");
                    //throw;
                }
                
                _radius = value;

                
            }
        }


        public override double CalcVolume()
        {
            var result = Math.PI * Math.Pow(_radius, 3);

            return Math.Round(result, 2); //Rounds the number by 2 decimal places
        }

        /*
         * 5. Override the ToString() method inherited from ThreeDShape, 
         * make it display information about the sphere.
         */
        public override string ToString()
        {
            return string.Format(base.ToString() + "\nRadius: " + Radius + "\n");
        }
    }
}