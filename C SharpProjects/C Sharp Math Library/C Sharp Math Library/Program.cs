using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Math_Library
{

    class Program
    {

     class Vector2
        {

            public int X;
            public int Y;

            public Vector2(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }

            public static Vector2 operator +(Vector2 a, Vector2 b)
            {
                return new Vector2(a.X + b.X, a.Y + b.Y);
            }

            public static Vector2 operator -(Vector2 a, Vector2 b)
            {
                return new Vector2(a.X - b.X, a.Y - b.Y);
            }

            public static Vector2 operator *(Vector2 a, Vector2 b)
            {
                return new Vector2(a.X * b.X, a.Y * b.Y);
            }

            public static Vector2 operator /(Vector2 a, Vector2 b)
            {
                return new Vector2(a.X / b.X, a.Y / b.Y);
            }

            public static Vector2 operator %(Vector2 a, Vector2 b)
            {
                return new Vector2(a.X % b.X, a.Y % b.Y);
            }

            public override string ToString()
            {
                return (String.Format("{0},{1}", X, Y));
            }

        }

     class Vector3
        {
            public int X;
            public int Y;
            public int Z;

            public Vector3(int X, int Y, int Z)
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
            }

            public static Vector3 operator +(Vector3 a, Vector3 b)
            {
                return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
            }

            public static Vector3 operator -(Vector3 a, Vector3 b)
            {
                return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
            }

            public static Vector3 operator *(Vector3 a, Vector3 b)
            {
                return new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
            }

            public static Vector3 operator /(Vector3 a, Vector3 b)
            {
                return new Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
            }

            public static Vector3 operator %(Vector3 a, Vector3 b)
            {
                return new Vector3(a.X % b.X, a.Y % b.Y, a.Z % b.Z);
            }

            public override string ToString()
            {
                return (String.Format("{0},{1},{2}", X, Y, Z));
            }

        }

     class Color
        {
            public int R;
            public int G;
            public int B;
            public int A;

            public Color(int R, int G, int B, int A)
            {
                this.R = R;
                this.G = G;
                this.B = B;
                this.A = A;

            }

            public static Color operator +(Color a, Color b)
            {
                return new Color(a.R + b.R, a.G + b.G, a.B + b.B, a.A + b.A);
            }

            public static Color operator -(Color a, Color b)
            {
                return new Color(a.R - b.R, a.G - b.G, a.B - b.B, a.A - b.A);
            }

            public static Color operator *(Color a, Color b)
            {
                return new Color(a.R * b.R, a.G * b.G, a.B * b.B, a.A * b.A);
            }

            public static Color operator /(Color a, Color b)
            {
                return new Color(a.R / b.R, a.G / b.G, a.B / b.B, a.A / b.A);
            }

            public static Color operator %(Color a, Color b)
            {
                return new Color(a.R % b.R, a.G % b.G, a.B % b.B, a.A % b.A);
            }

            public override string ToString()
            {
                return (String.Format("{0},{1},{2}", R, G, B, A));
            }

        }


        static void Main(string[] args)
        {
   
            Vector2 nvec = new Vector2(15, 10);
            Vector2 nvec1 = new Vector2 (15, 10);

            Vector2 Sum = nvec + nvec1;
            Vector2 Difference = nvec - nvec1;
            Vector2 Product = nvec * nvec1;
            Vector2 Quotient = nvec / nvec1;
            Vector2 Modulus = nvec % nvec1;

            Console.WriteLine("Vector 2 Math: ");
            Console.WriteLine("Sum is: ({0})", Sum);
            Console.WriteLine("Difference is: ({0})", Difference);
            Console.WriteLine("Product is: ({0})", Product);
            Console.WriteLine("Quotient is: ({0})", Quotient);
            Console.WriteLine("Modulus is: ({0})\n", Modulus);

            Vector3 nvec2 = new Vector3(15, 10, 5);
            Vector3 nvec3 = new Vector3(15, 10, 5);

            Vector3 Sum2 = nvec2 + nvec3;
            Vector3 Difference2 = nvec2 - nvec3;
            Vector3 Product2 = nvec2 * nvec3;
            Vector3 Quotient2 = nvec2 / nvec3;
            Vector3 Modulus2 = nvec2 % nvec3;

            Console.WriteLine("Vector 3 Math: ");
            Console.WriteLine("Sum is: ({0})", Sum2);
            Console.WriteLine("Difference is: ({0})", Difference2);
            Console.WriteLine("Product is: ({0})", Product2);
            Console.WriteLine("Quotient is: ({0})", Quotient2);
            Console.WriteLine("Modulus is: ({0})\n", Modulus2);


            Color white = new Color(255, 255, 255, 1);
            Color black = new Color(1, 1, 1, 1);

            Color Sum3 = white + black;
            Color Difference3 = white - black;
            Color Product3 = white * black;
            Color Quotient3 = white / black;
            Color Modulus3 = white % black;

            Console.WriteLine("Color Math: ");
            Console.WriteLine("Sum is: ({0})", Sum3);
            Console.WriteLine("Difference is: ({0})", Difference3);
            Console.WriteLine("Product is: ({0})", Product3);
            Console.WriteLine("Quotient is: ({0})", Quotient3);
            Console.WriteLine("Modulus is: ({0})", Modulus3);

            Console.ReadLine();


        }

    }

}
