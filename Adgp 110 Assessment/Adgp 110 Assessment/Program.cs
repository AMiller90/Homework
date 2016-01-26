using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace Adgp110Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2<float> nvec = new Vector2<float>(5.0f, 5.0f);
            Vector2<float> nvec1 = new Vector2<float>(5.0f, 5.0f);

            //Vector2<char> Sum = nvec + nvec1;
            //Vector2<double> Difference = nvec - nvec1;
            //Vector2<char> Product = nvec * nvec1;
            //Vector2<double> Quotient = nvec / nvec1;
            //Vector2<double> Modulus = nvec % nvec1;
            //double Magnitude = Vector2<int>.Mag(nvec1);
            Vector2<float> Normalise = Vector2<float>.Normalise(nvec);
            //double Dot = Vector2<double>.Dot(nvec, nvec1);

            Console.WriteLine("Vector 2 Math: ");
            //Console.WriteLine("Sum is: ({0})", Sum);
            //Console.WriteLine("Difference is: ({0})", Difference);
            //Console.WriteLine("Product is: ({0})", Product);
            //Console.WriteLine("Quotient is: ({0})", Quotient);
            //Console.WriteLine("Modulus is: ({0})\n", Modulus);
            //Console.WriteLine("Magnitude is: ({0})\n", Magnitude);
            Console.WriteLine("Normalised is: ({0})\n", Normalise);
            //Console.WriteLine("Dot Product is: ({0})\n", Dot);



            //Vector3<float> nvec2 = new Vector3<float>(10, 10, 5);
            //Vector3<float> nvec3 = new Vector3<float>(10, 100, 25);

            //Vector3<float> Sum2 = nvec2 + nvec3;
            //Vector3<float> Difference2 = nvec2 - nvec3;
            //Vector3<float> Product2 = nvec2 * nvec3;
            //Vector3<float> Quotient2 = nvec2 / nvec3;
           // Vector3<float> Modulus2 = nvec2 % nvec3;
            //double Magnitude2 = Vector3<double>.Mag(nvec2);
            //Vector3<float> Normalise2 = Vector3<float>.Normalise(nvec2);
            //float Dot2 = Vector3<float>.Dot(nvec2, nvec3);
            //Vector3<float> Cross = Vector3<float>.Cross(nvec2, nvec3);

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

            //Color<double> white = new Color<double>(0, 0, 0, 0);
            //Color<float> black = new Color<float>(1, 1, 1, 1);

            //Color<float> Sum3 = white + black;
            //Color<float> Difference3 = white - black;
            //Color<float> Product3 = white * black;
            //Color<float> Quotient3 = white / black;
            //Color<float> Modulus3 = white % black;
            //double Magnitude3 = Color<double>.Mag(white);
            //Color<float> Normalise3 = Color<float>.Normalise(white);
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
            //char[] cHex = { '#', '1', '1', '1', '1', '1', '1' };

            //Color<float> hecdec = Color<float>.HexConv(cHex);

            //Console.WriteLine("RGBA Values Are: ({0})\n", hecdec);

            Console.ReadLine();

        }
    }

}
