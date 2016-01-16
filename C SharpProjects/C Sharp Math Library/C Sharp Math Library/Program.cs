using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Math_Library
{

    class Program
    {

        class Vector2<T>
        {

            public T X;
            public T Y;

            public Vector2(T X, T Y)
            {
                this.X = X;
                this.Y = Y;
            }

            public static Vector2<T> operator +(Vector2<T> a, Vector2<T> b)
            {//Checks At Runtime 
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector2<T>(d_a.X + d_b.X, d_a.Y + d_b.Y);
            }

            public static Vector2<T> operator -(Vector2<T> a, Vector2<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector2<T>(d_a.X - d_b.X, d_a.Y - d_b.Y);
            }

            public static Vector2<T> operator *(Vector2<T> a, Vector2<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector2<T>(d_a.X * d_b.X, d_a.Y * d_b.Y);
            }

            public static Vector2<T> operator /(Vector2<T> a, Vector2<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector2<T>(d_a.X / d_b.X, d_a.Y / d_b.Y);
            }

            public static Vector2<T> operator %(Vector2<T> a, Vector2<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector2<T>(d_a.X % d_b.X, d_a.Y % d_b.Y);
            }

            public override string ToString()
            {
                return (String.Format("{0},{1}", X, Y));
            }

        }

        class Vector3<T>
        {
            public T X;
            public T Y;
            public T Z;

            public Vector3(T X, T Y, T Z)
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
            }

            public static Vector3<T> operator +(Vector3<T> a, Vector3<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector3<T>(d_a.X + d_b.X, d_a.Y + d_b.Y, d_a.Z + d_b.Z);
            }

            public static Vector3<T> operator -(Vector3<T> a, Vector3<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector3<T>(d_a.X - d_b.X, d_a.Y - d_b.Y, d_a.Z - d_b.Z);
            }

            public static Vector3<T> operator *(Vector3<T> a, Vector3<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector3<T>(d_a.X * d_b.X, d_a.Y * d_b.Y, d_a.Z * d_b.Z);
            }

            public static Vector3<T> operator /(Vector3<T> a, Vector3<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector3<T>(d_a.X / d_b.X, d_a.Y / d_b.Y, d_a.Z / d_b.Z);
            }

            public static Vector3<T> operator %(Vector3<T> a, Vector3<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Vector3<T>(d_a.X % d_b.X, d_a.Y % d_b.Y, d_a.Z % d_b.Z);
            }

            public override string ToString()
            {
                return (String.Format("{0},{1},{2}", X, Y, Z));
            }

        }

        class Color<T>
        {
            public T R;
            public T G;
            public T B;
            public T A;

            public Color(T R, T G, T B, T A)
            {
                this.R = R;
                this.G = G;
                this.B = B;
                this.A = A;

            }

            public static Color<T> operator +(Color<T> a, Color<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Color<T>(d_a.R + d_b.R, d_a.G + d_b.G, d_a.B + d_b.B, d_a.A + d_b.A);
            }

            public static Color<T> operator -(Color<T> a, Color<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Color<T>(d_a.R - d_b.R, d_a.G - d_b.G, d_a.B - d_b.B, d_a.A - d_b.A);
            }

            public static Color<T> operator *(Color<T> a, Color<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Color<T>(d_a.R * d_b.R, d_a.G * d_b.G, d_a.B * d_b.B, d_a.A * d_b.A);
            }

            public static Color<T> operator /(Color<T> a, Color<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Color<T>(d_a.R / d_b.R, d_a.G / d_b.G, d_a.B / d_b.B, d_a.A / d_b.A);
            }

            public static Color<T> operator %(Color<T> a, Color<T> b)
            {
                dynamic d_a = a;
                dynamic d_b = b;

                return new Color<T>(d_a.R % d_b.R, d_a.G % d_b.G, d_a.B % d_b.B, d_a.A % d_b.A);
            }

            public override string ToString()
            {
                return (String.Format("{0},{1},{2},{3}", R, G, B, A));
            }
        }



        static void Main(string[] args)
        {

            Vector2<int> nvec = new Vector2<int>(15, 10);
            Vector2<int> nvec1 = new Vector2<int>(15, 10);

            Vector2<int> Sum = nvec + nvec1;
            Vector2<int> Difference = nvec - nvec1;
            Vector2<int> Product = nvec * nvec1;
            Vector2<int> Quotient = nvec / nvec1;
            Vector2<int> Modulus = nvec % nvec1;

            Console.WriteLine("Vector 2 Math: ");
            Console.WriteLine("Sum is: ({0})", Sum);
            Console.WriteLine("Difference is: ({0})", Difference);
            Console.WriteLine("Product is: ({0})", Product);
            Console.WriteLine("Quotient is: ({0})", Quotient);
            Console.WriteLine("Modulus is: ({0})\n", Modulus);

            Vector3<int> nvec2 = new Vector3<int>(15, 10, 5);
            Vector3<int> nvec3 = new Vector3<int>(15, 10, 5);

            Vector3<int> Sum2 = nvec2 + nvec3;
            Vector3<int> Difference2 = nvec2 - nvec3;
            Vector3<int> Product2 = nvec2 * nvec3;
            Vector3<int> Quotient2 = nvec2 / nvec3;
            Vector3<int> Modulus2 = nvec2 % nvec3;

            Console.WriteLine("Vector 3 Math: ");
            Console.WriteLine("Sum is: ({0})", Sum2);
            Console.WriteLine("Difference is: ({0})", Difference2);
            Console.WriteLine("Product is: ({0})", Product2);
            Console.WriteLine("Quotient is: ({0})", Quotient2);
            Console.WriteLine("Modulus is: ({0})\n", Modulus2);


            Color<int> white = new Color<int>(255, 255, 255, 1);
            Color<int> black = new Color<int>(1, 1, 1, 1);

            Color<int> Sum3 = white + black;
            Color<int> Difference3 = white - black;
            Color<int> Product3 = white * black;
            Color<int> Quotient3 = white / black;
            Color<int> Modulus3 = white % black;

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

