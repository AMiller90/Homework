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


            //Function To Convert Hexadecimal Numbers To RGBA Values
             public static Color<T>HexConv(char[] Hex)
            {

                //Create a temp variable for holding a number
                int temp;

                //Create an instance of a color object
                Color<int> Hexvec = new Color<int>(0, 0, 0, 0);


                //Checks the first index of the inputted value
                if (Hex[0] == '#')
                {//For Loop will loop through each index of the inputted array as long as its less than 7
                    for (int i = 1; i < 7; i++)
                    {//Checks if the current index is equal to 0
                        if (Hex[i] == '0')
                        {//set temp variable to 0
                            temp = 0;
                        }
                        //Checks if the current index is equal to 1
                        else if (Hex[i] == '1')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 16
                                temp = 16;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 1
                                temp = 1;
                            }
                        }
                        //Checks if the current index is equal to 2
                        else if (Hex[i] == '2')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 32
                                temp = 32;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 2
                                temp = 2;
                            }
                        }
                        //Checks if the current index is equal to 3
                        else if (Hex[i] == '3')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 48
                                temp = 48;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 3
                                temp = 3;
                            }
                        }
                        //Checks if the current index is equal to 4
                        else if (Hex[i] == '4')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 64
                                temp = 64;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 4
                                temp = 4;
                            }
                        }
                        //Checks if the current index is equal to 5
                        else if (Hex[i] == '5')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 80
                                temp = 80;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 5
                                temp = 5;
                            }
                        }
                        //Checks if the current index is equal to 6
                        else if (Hex[i] == '6')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 96
                                temp = 96;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 6
                                temp = 6;
                            }
                        }
                        //Checks if the current index is equal to 7
                        else if (Hex[i] == '7')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 112
                                temp = 112;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 7
                                temp = 7;
                            }
                        }
                        //Checks if the current index is equal to 8
                        else if (Hex[i] == '8')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 128
                                temp = 128;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 8
                                temp = 8;
                            }
                        }
                        //Checks if the current index is equal to 9
                        else if (Hex[i] == '9')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 144
                                temp = 144;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 19
                                temp = 9;
                            }
                        }
                        //Checks if the current index is equal to A
                        else if (Hex[i] == 'A')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 160
                                temp = 160;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 10
                                temp = 10;
                            }
                        }
                        //Checks if the current index is equal to B
                        else if (Hex[i] == 'B')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 176
                                temp = 176;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 11
                                temp = 11;
                            }
                        }
                        //Checks if the current index is equal to C
                        else if (Hex[i] == 'C')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 192
                                temp = 192;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 12
                                temp = 12;
                            }
                        }
                        //Checks if the current index is equal to D
                        else if (Hex[i] == 'D')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 208
                                temp = 208;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 13
                                temp = 13;
                            }
                        }
                        //Checks if the current index is equal to E
                        else if (Hex[i] == 'E')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 224
                                temp = 224;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 14
                                temp = 14;
                            }
                        }
                        //Checks if the current index is equal to F
                        else if (Hex[i] == 'F')
                        {//if the current i in the loop is 1, 3, or 5
                            if (i == 1 || i == 3 || i == 5)
                            {//temp is set to 240
                                temp = 240;
                            }
                            //if current i is not 1, 3, or 5
                            else
                            {//temp is set to 15
                                temp = 15;
                            }
                        }
                        else
                        {//If inputted a value other than any of the ones above then set all values to 0 
                            Hexvec.R = 0; Hexvec.G = 0; Hexvec.B = 0;
                            //print out invalid code
                            Console.WriteLine("Invalid Code!\n");
                            //break out statement
                            break;

                        }
                        //if statement to check current value of i so the temp value can be assigned to the appropriate variable
                        if (i == 1)
                        {//r value is assigned the temp value
                            Hexvec.R = temp;
                        }
                        //if statement to check current value of i so the temp value can be assigned to the appropriate variable
                        else if (i == 2)
                        {//r value is added and assigned the temp value
                            Hexvec.R += temp;
                        }
                        //if statement to check current value of i so the temp value can be assigned to the appropriate variable
                        else if (i == 3)
                        {//g value is assigned the temp value
                            Hexvec.G = temp;
                        }
                        //if statement to check current value of i so the temp value can be assigned to the appropriate variable
                        else if (i == 4)
                        {//g value is added and assigned the temp value
                            Hexvec.G += temp;
                        }
                        //if statement to check current value of i so the temp value can be assigned to the appropriate variable
                        else if (i == 5)
                        {//b value is assigned the temp value
                            Hexvec.B = temp;
                        }
                        //if statement to check current value of i so the temp value can be assigned to the appropriate variable
                        else
                        {//b value is added and assigned the temp value
                            Hexvec.B += temp;
                        }

                        //end of for loop
                    }
                    //Set the a value to 255
                    Hexvec.A = 255;

                }
                //If first inputted value was not a # symbol Then do this
                else
                {//Set values to 0 
                    Hexvec.R = 0; Hexvec.G = 0; Hexvec.B = 0;
                    //Print an error code
                   Console.WriteLine("Invalid Code!\n");
                }

                //Create Variables That Can Be Changed At Runtime
                dynamic d_r = Hexvec.R;
                dynamic d_g = Hexvec.G;
                dynamic d_b = Hexvec.B;
                dynamic d_a = Hexvec.A;

                //Return The New Vector With The Converted Numbers
                return new Color<T>(d_r, d_g, d_b, d_a);

            }


            //Allows Numbers to be converted and formatted so they can be printed to screen appropriately
            public override string ToString()
            {//return the formatted string
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


            //Create An Array For Storing The Input Variables From The User
            //char[] Hex = new char[8];

            Color<float> white = new Color<float>(0, 0, 0, 0);
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

            //Create An Array For Storing The Input Variables From The User
            char[] Hex = { '#', '1', '1', '1', '1', '1', '1' };

            Color<int> hecdec = Color<int>.HexConv(Hex);

            Console.WriteLine("RGBA Values Are: ({0})\n", hecdec);

            Console.ReadLine();

        }

    }
}

