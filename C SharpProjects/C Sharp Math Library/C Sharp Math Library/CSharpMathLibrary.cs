using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Math_Library
{

    class Program
    {
        //Vector2 Class
        class Vector2<T>
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
            public static Vector2<T>Normalise(Vector2<T> a)
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
            public static T Dot(Vector2 <T>a, Vector2 <T>b)
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

        //Vector3 Class
        class Vector3<T>
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

                //Return new vector(Divide X Values for X Place, Divide Y Values for Y place, Divide Z Values for Z place)
                return new Vector3<T>(d_a.X / d_b.X, d_a.Y / d_b.Y, d_a.Z / d_b.Z);
            }

            //Operator Overload % Operator
            public static Vector3<T> operator %(Vector3<T> a, Vector3<T> b)
            {
                //Dynamic Checks At Runtime for data type
                dynamic d_a = a;
                dynamic d_b = b;

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
            public static Vector3<T> Cross(Vector3 <T> a, Vector3 <T>  b)
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

        //Color Class
        class Color<T>
        {
            //Set Up Public Variables
            public T R;
            public T G;
            public T B;
            public T A;

            //Constructor
            public Color(T R, T G, T B, T A)
            {
                //Set Variables
                this.R = R;
                this.G = G;
                this.B = B;
                this.A = A;

            }

            //Operator Overload + Operator
            public static Color<T> operator +(Color<T> a, Color<T> b)
            {
                //Dynamic Checks At Runtime for data type
                dynamic d_a = a;
                dynamic d_b = b;

                //Return new vector(Add R Values for R Place, Add G Values for G place, Add B Values for B place, Add A Values for A place)
                return new Color<T>(d_a.R + d_b.R, d_a.G + d_b.G, d_a.B + d_b.B, d_a.A + d_b.A);
            }

            //Operator Overload - Operator
            public static Color<T> operator -(Color<T> a, Color<T> b)
            {
                //Dynamic Checks At Runtime for data type
                dynamic d_a = a;
                dynamic d_b = b;

                //Return new vector(Subtract R Values for R Place, Subtract G Values for G place, Subtract B Values for B place, Subtract A Values for A place)
                return new Color<T>(d_a.R - d_b.R, d_a.G - d_b.G, d_a.B - d_b.B, d_a.A - d_b.A);
            }

            //Operator Overload * Operator
            public static Color<T> operator *(Color<T> a, Color<T> b)
            {
                //Dynamic Checks At Runtime for data type
                dynamic d_a = a;
                dynamic d_b = b;

                //Return new vector(Multiply R Values for R Place, Multiply G Values for G place, Multiply B Values for B place, Multiply A Values for A place)
                return new Color<T>(d_a.R * d_b.R, d_a.G * d_b.G, d_a.B * d_b.B, d_a.A * d_b.A);
            }

            //Operator Overload / Operator
            public static Color<T> operator /(Color<T> a, Color<T> b)
            {
                //Dynamic Checks At Runtime for data type
                dynamic d_a = a;
                dynamic d_b = b;

                //Return new vector(Divide R Values for R Place, Divide G Values for G place, Divide B Values for B place, Divide A Values for A place)
                return new Color<T>(d_a.R / d_b.R, d_a.G / d_b.G, d_a.B / d_b.B, d_a.A / d_b.A);
            }

            //Operator Overload % Operator
            public static Color<T> operator %(Color<T> a, Color<T> b)
            {
                //Dynamic Checks At Runtime for data type
                dynamic d_a = a;
                dynamic d_b = b;

                //Return new vector(Modulus R Values for R Place, Modulus G Values for G place, Modulus B Values for B place, Modulus A Values for A place)
                return new Color<T>(d_a.R % d_b.R, d_a.G % d_b.G, d_a.B % d_b.B, d_a.A % d_b.A);
            }

            //Function For Returning Magnitude Of Passed In Vector
            public static double Mag(Color<T> a)
            {
                //Dynamic Checks At Runtime for data type
                dynamic d_a = a;

                //Variable used to store squared values of passed in vector values
                double Asquared;

                //Variable to hold square root value
                double Asqrt;

                //Square each coordinate and add together then store into new variable
                Asquared = (d_a.R * d_a.R) + (d_a.G * d_a.G) + (d_a.B * d_a.B) + (d_a.A * d_a.A);

                //Get the square root of the variable and store into a new variable
                Asqrt = Math.Sqrt(Asquared);

                //Return Magnitude as a double to be more precise
                return Asqrt;

            }

            //Function For Returning A Normalised Coordinates Of A Passed In Vector
            public static Color<T> Normalise(Color<T> a)
            {
                //Dynamic Checks At Runtime for data type
                dynamic d_a = a;

                //Variable to hold square root value
                T Asqrt;

                //Get the square root of the variable and store into a new variable
                Asqrt = Math.Sqrt((d_a.R * d_a.R) + (d_a.G * d_a.G) + (d_a.B * d_a.B) + (d_a.A * d_a.A));

                //Return the normalised vector(R Coordinate Divided by Asqrt Sets R Coordinate Of New Vector, 
                //G Coordinate Divided by Asqrt Sets G Coordinate Of New Vector, 
                //B Coordinate Divided by Asqrt Sets B Coordinate Of New Vector,
                //A Coordinate Divided by Asqrt Sets A Coordinate Of New Vector)
                return new Color<T>(d_a.R / Asqrt, d_a.G / Asqrt, d_a.B / Asqrt, d_a.A / Asqrt);

            }

            //Function For Returning The Dot Product Of 2 Passed In Vectors
            public static T Dot(Color<T> a, Color<T> b)
            {
                //Dynamic Checks At Runtime for data type
                dynamic d_a = a;
                dynamic d_b = b;

                //Multiply the passed in R values and the G values and the B values and the A values then add them together and return the product
                return (d_a.R * d_b.R) + (d_a.G * d_b.G) + (d_a.B * d_b.B) + (d_a.A * d_b.A);
                

            }


            public override string ToString()
            {
                return (String.Format("{0},{1},{2},{3}", R, G, B, A));
            }
        }


        //Main Function 
        static void Main(string[] args)
        {

            //Vector2<int> nvec = new Vector2<int>(15, 10);
            //Vector2<int> nvec1 = new Vector2<int>(15, 10);

            //Vector2<int> Sum = nvec + nvec1;
            //Vector2<int> Difference = nvec - nvec1;
            //Vector2<int> Product = nvec * nvec1;
            //Vector2<int> Quotient = nvec / nvec1;
            //Vector2<int> Modulus = nvec % nvec1;
            //double Magnitude = Vector2<int>.Mag(nvec1);
            //Vector2<double> Normalise = Vector2<double>.Normalise(nvec);
            //int Dot = Vector2<int>.Dot(nvec, nvec1);

            //Console.WriteLine("Vector 2 Math: ");
            //Console.WriteLine("Sum is: ({0})", Sum);
            //Console.WriteLine("Difference is: ({0})", Difference);
            //Console.WriteLine("Product is: ({0})", Product);
            //Console.WriteLine("Quotient is: ({0})", Quotient);
            //Console.WriteLine("Modulus is: ({0})\n", Modulus);
            //Console.WriteLine("Magnitude is: ({0})\n", Magnitude);
            //Console.WriteLine("Normalised is: ({0})\n", Normalise);
            //Console.WriteLine("Dot Product is: ({0})\n", Dot);



            //Vector3<float> nvec2 = new Vector3<float>(15, 10, 5);
            //Vector3<float> nvec3 = new Vector3<float>(150, 100, 25);

            //Vector3<int> Sum2 = nvec2 + nvec3;
            //Vector3<int> Difference2 = nvec2 - nvec3;
            //Vector3<int> Product2 = nvec2 * nvec3;
            //Vector3<int> Quotient2 = nvec2 / nvec3;
            //Vector3<int> Modulus2 = nvec2 % nvec3;
            //double Magnitude2 = Vector3<int>.Mag(nvec2);
            //Vector3<double> Normalise2 = Vector3<double>.Normalise(nvec2);
            //int Dot2 = Vector3<int>.Dot(nvec2, nvec3);
            //Vector3<int> Cross = Vector3<int>.Cross(nvec2, nvec3);

            //Console.WriteLine("Vector 3 Math: ");
            //Console.WriteLine("Sum is: ({0})", Sum2);
            //Console.WriteLine("Difference is: ({0})", Difference2);
            //Console.WriteLine("Product is: ({0})", Product2);
            //Console.WriteLine("Quotient is: ({0})", Quotient2);
            //Console.WriteLine("Modulus is: ({0})\n", Modulus2);
            //Console.WriteLine("Magnitude is: ({0})\n", Magnitude2);
            //Console.WriteLine("Normalised is: ({0})\n", Normalise2);
            //Console.WriteLine("Dot Product is: ({0})\n", Dot2);
            //Console.WriteLine("Cross Product is: ({0})\n", Cross);



            //Color<float> white = new Color<float>(255, 255, 255, 1);
            //Color<float> black = new Color<float>(1, 1, 1, 1);

            //Color<int> Sum3 = white + black;
            //Color<int> Difference3 = white - black;
            //Color<int> Product3 = white * black;
            //Color<int> Quotient3 = white / black;
            //Color<int> Modulus3 = white % black;
            //double Magnitude3 = Color<int>.Mag(white);
            //Color<double> Normalise3 = Color<double>.Normalise(white);
            //float Dot3 = Color<float>.Dot(white, black);

            //Console.WriteLine("Color Math: ");
            //Console.WriteLine("Sum is: ({0})", Sum3);
            //Console.WriteLine("Difference is: ({0})", Difference3);
            //Console.WriteLine("Product is: ({0})", Product3);
            //Console.WriteLine("Quotient is: ({0})", Quotient3);
            //Console.WriteLine("Modulus is: ({0})", Modulus3);
            //Console.WriteLine("Magnitude is: ({0})\n", Magnitude3);
            //Console.WriteLine("Normalised is: ({0})\n", Normalise3);
            //Console.WriteLine("Dot Product is: ({0})\n", Dot3);

            Console.ReadLine();
        }

    }
}

