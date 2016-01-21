using System;


namespace MathLibrary
{
    public class Vector2<T>
    {//Set Up Public Variables
        public T X;
        public T Y;

        //Constructor
        public Vector2(T X, T Y)
        {//Set Variables
            this.X = X;
            this.Y = Y;
        }

        //Operator Overload + Operator
        public static Vector2<T> operator +(Vector2<T> a, Vector2<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Return new vector(Add X Values for X Place, Add Y Values for Y place)
            return new Vector2<T>(d_a.X + d_b.X, d_a.Y + d_b.Y);
        }

        //Operator Overload - Operator
        public static Vector2<T> operator -(Vector2<T> a, Vector2<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Return new vector(Subtract X Values for X Place, Subtract Y Values for Y place)
            return new Vector2<T>(d_a.X - d_b.X, d_a.Y - d_b.Y);
        }

        //Operator Overload * Operator
        public static Vector2<T> operator *(Vector2<T> a, Vector2<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Return new vector(Multiply X Values for X Place, Multiply Y Values for Y place)
            return new Vector2<T>(d_a.X * d_b.X, d_a.Y * d_b.Y);
        }

        //Operator Overload / Operator
        public static Vector2<T> operator /(Vector2<T> a, Vector2<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Return new vector(Divide X Values for X Place, Divide Y Values for Y place)
            return new Vector2<T>(d_a.X / d_b.X, d_a.Y / d_b.Y);
        }

        //Operator Overload % Operator
        public static Vector2<T> operator %(Vector2<T> a, Vector2<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Return new vector(Modulus X Values for X Place, Modulus Y Values for Y place)
            return new Vector2<T>(d_a.X % d_b.X, d_a.Y % d_b.Y);
        }

        //Function For Returning Magnitude Of Passed In Vector
        public static double Mag(Vector2<T> a)
        {
            //Variable used to store squared values of passed in vector values
            float Asquared;

            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;

            //Variable to hold square root value
            double Asqrt;

            //Square each coordinate and add together then store into new variable
            Asquared = (d_a.X * d_a.X) + (d_a.Y * d_a.Y);

            //Get the square root of the variable and store into a new variable
            Asqrt = Math.Sqrt(Asquared);

            //Return Magnitude as a double to be more precise
            return Asqrt;
        }

        //Function For Returning A Normalised Coordinates Of A Passed In Vector
        public static Vector2<T> Normalise(Vector2<T> a)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;

            //Variable to hold square root value
            T Asqrt;

            //Square each coordinate and add together then store into new variable 
            Asqrt = Math.Sqrt((d_a.X * d_a.X) + (d_a.Y * d_a.Y));

            //Return the normalised vector(X coordinate divided by Asqrt Variable is the X Value Of New Vector, Y coordinate divided by Asqrt Variable is the Y Value Of New Vector)
            return new Vector2<T>(d_a.X / Asqrt, d_a.Y / Asqrt);

        }

        //Function For Returning The Dot Product Of 2 Passed In Vectors
        public static T Dot(Vector2<T> a, Vector2<T> b)
        {
            //Dynamic Checks At Runtime for data type
            dynamic d_a = a;
            dynamic d_b = b;

            //Multiply the passed in x values and the y values then add them together and return the product
            return (d_a.X * d_b.X) + (d_a.Y * d_b.Y);
        }

        //Override The ToString() Method So We Can Write Strings
        public override string ToString()
        {
            return (String.Format("{0},{1}", X, Y));
        }

    }

}
