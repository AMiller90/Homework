using System;


namespace MathLibrary
{
    public class Vector3<T>
    {
        //Set Up Public Variables
        public T X;
        public T Y;
        public T Z;

        //Constructor
        public Vector3(T X, T Y, T Z)
        {
            //Set Variables
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        //Operator Overload + Operator
        public static Vector3<T> operator +(Vector3<T> a, Vector3<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Return new vector(Add X Values for X Place, Add Y Values for Y place, Add Z Values for Z place)
            return new Vector3<T>(d_a.X + d_b.X, d_a.Y + d_b.Y, d_a.Z + d_b.Z);
        }

        //Operator Overload - Operator
        public static Vector3<T> operator -(Vector3<T> a, Vector3<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Return new vector(Subtract X Values for X Place, Subtract Y Values for Y place, Subtract Z Values for Z place)
            return new Vector3<T>(d_a.X - d_b.X, d_a.Y - d_b.Y, d_a.Z - d_b.Z);
        }

        //Operator Overload * Operator
        public static Vector3<T> operator *(Vector3<T> a, Vector3<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Return new vector(Multiply X Values for X Place, Multiply Y Values for Y place, Multiply Z Values for Z place)
            return new Vector3<T>(d_a.X * d_b.X, d_a.Y * d_b.Y, d_a.Z * d_b.Z);
        }

        //Operator Overload / Operator
        public static Vector3<T> operator /(Vector3<T> a, Vector3<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Check is either vector is going to have a 0 in their x or y components
            if (d_a.X == 0 || d_a.Y == 0 || d_a.Z == 0)
            {//Print Error Message
                Console.WriteLine("Error! Can't Divide By 0");
                //If so then just return the vectors
                return new Vector3<T>(d_a.X, d_a.Y, d_a.Z);
            }

            if (d_b.X == 0 || d_b.Y == 0 || d_b.Z == 0)
            {//Print Error Message
                Console.WriteLine("Error! Can't Divide By 0");
                //If so then just return the vectors
                return new Vector3<T>(d_b.X, d_b.Y, d_b.Z);
            }

            //Return new vector(Divide X Values for X Place, Divide Y Values for Y place, Divide Z Values for Z place)
            return new Vector3<T>(d_a.X / d_b.X, d_a.Y / d_b.Y, d_a.Z / d_b.Z);
        }

        //Operator Overload % Operator
        public static Vector3<T> operator %(Vector3<T> a, Vector3<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;


            //Check is either vector is going to have a 0 in their x or y components
            if (d_a.X == 0 || d_a.Y == 0 || d_a.Z == 0)
            {//Print Error Message
                Console.WriteLine("Error! Can't Divide By 0");
                //If so then just return the vectors
                return new Vector3<T>(d_a.X, d_a.Y, d_a.Z);
            }

            if (d_b.X == 0 || d_b.Y == 0 || d_b.Z == 0)
            {//Print Error Message
                Console.WriteLine("Error! Can't Divide By 0");
                //If so then just return the vectors
                return new Vector3<T>(d_b.X, d_b.Y, d_b.Z);
            }

            //Return new vector(Modulus X Values for X Place, Modulus Y Values for Y place, Modulus Z Values for Z place)
            return new Vector3<T>(d_a.X % d_b.X, d_a.Y % d_b.Y, d_a.Z % d_b.Z);
        }

        //Function For Returning Magnitude Of Passed In Vector
        public static double Mag(Vector3<T> a)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;

            //Variable used to store squared values of passed in vector values
            double Asquared;

            //Variable to hold square root value
            double Asqrt;

            //Square each coordinate and add together then store into new variable
            Asquared = (d_a.X * d_a.X) + (d_a.Y * d_a.Y) + (d_a.Z * d_a.Z);

            //Get the square root of the variable and store into a new variable
            Asqrt = Math.Sqrt(Asquared);

            //Return Magnitude as a double to be more precise
            return Asqrt;

        }

        //Function For Returning A Normalised Coordinates Of A Passed In Vector
        public static Vector3<T> Normalise(Vector3<T> a)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;

            //Variable to hold square root value
            T Asqrt;

            //Get the square root of the variable and store into a new variable
            Asqrt = Math.Sqrt((d_a.X * d_a.X) + (d_a.Y * d_a.Y) + (d_a.Z * d_a.Z));

            //Return the normalised vector(X Coordinate Divided by Asqrt Sets X Coordinate Of New Vector, 
            //Y Coordinate Divided by Asqrt Sets Y Coordinate Of New Vector, 
            //Z Coordinate Divided by Asqrt Sets Z Coordinate Of New Vector)
            return new Vector3<T>(d_a.X / Asqrt, d_a.Y / Asqrt, d_a.Z / Asqrt);

        }

        //Function For Returning The Dot Product Of 2 Passed In Vectors
        public static T Dot(Vector3<T> a, Vector3<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Multiply the passed in x values and the y values and the z values then add them together and return the product
            return (d_a.X * d_b.X) + (d_a.Y * d_b.Y) + (d_a.Z * d_b.Z);

        }

        //Function For Returning The Cross Product Of 2 Passed In Vectors
        public static Vector3<T> Cross(Vector3<T> a, Vector3<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Return cross product
            return new Vector3<T>((d_a.Y * d_b.Z) - (d_a.Z * d_b.Y), (d_a.Z * d_b.X) - (d_a.X * d_b.Z), (d_a.X * d_b.Y) - (d_a.Y * d_b.X));

        }


        //Override The ToString() Method So We Can Write Strings
        public override string ToString()
        {
            return (String.Format("{0},{1},{2}", X, Y, Z));
        }

    }

}
