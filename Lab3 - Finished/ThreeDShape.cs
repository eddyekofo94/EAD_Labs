namespace Lab3_Finished
{
    //1.    Implement an abstract class ThreeDShape

    public abstract class ThreeDShape : IHasVolume
    {
        //3. Implement appropriate constructors for the class

        protected ThreeDShape(string type)
        {
            Type = type;
        }

        protected ThreeDShape()
        {
        }
        /*
         * 2. The class should have a field which stores the type of the shape
         * (e.g. sphere, cylinder, cone etc.), and a public read-only property
         * corresponding to this field.
         */

        protected string Type { get; set; }

        /*
             * 4. Implement an abstract method which calculates the volume of the shape. 
         */
        public abstract double CalcVolume();

        /*
         * 5. Override the ToString() method inherited from System.Object, 
         * make it display information about the shape.
         */

        public override string ToString()
        {
            return string.Format("Type of shape: " + Type + "\nVolume: " + CalcVolume());
            //string details = "Type of shape: {0}, Volume: {1}", Type, Volumes().ToString();
            //return details;
        }
    }
}