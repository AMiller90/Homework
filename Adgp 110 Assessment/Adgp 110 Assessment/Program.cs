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


            //Vector3<int> nvec = new Vector3<int>(5, 5, 5);
            //Vector2<int> nvec1 = new Vector2<int>(5, 5);


            //int mag = Vector3<int>.Mag(nvec);

            //Console.WriteLine("Mag is: ({0})", mag);
            //Vector2<char> Sum = nvec + nvec1;
            //Vector2<double> Difference = nvec - nvec1;
            //Vector2<char> Product = nvec * nvec1;
            //Vector2<double> Quotient = nvec / nvec1;
            //Vector2<double> Modulus = nvec % nvec1;
            //double Magnitude = Vector2<int>.Mag(nvec1);
            //Vector2<int> Normalise = Vector2<int>.Normalise(nvec1);
            //double Dot = Vector2<double>.Dot(nvec, nvec1);

            //Console.WriteLine("Vector 2 Math: ");
            //Console.WriteLine("Sum is: ({0})", Sum);
            //Console.WriteLine("Difference is: ({0})", Difference);
            //Console.WriteLine("Product is: ({0})", Product);
            //Console.WriteLine("Quotient is: ({0})", Quotient);
            //Console.WriteLine("Modulus is: ({0})\n", Modulus);
            //Console.WriteLine("Magnitude is: ({0})\n", Magnitude);
            //Console.WriteLine("Normalised is: ({0})\n", Normalise);
            //Console.WriteLine("Dot Product is: ({0})\n", Dot);



            //Vector3<float> nvec2 = new Vector3<float>(1,2,3);
            //Vector3<float> nvec3 = new Vector3<float>(1.0f, 2.0f, 3.0f);

            //Vector3<string> Sum2 = nvec2 + nvec3;
            //Vector3<string> Difference2 = nvec2 - nvec3;
            //Vector3<string> Product2 = nvec2 * nvec3;
            //Vector3<string> Quotient2 = nvec2 / nvec3;
            //Vector3<string> Modulus2 = nvec2 % nvec3;
            //float Magnitude2 = Vector3<float>.Mag(nvec2);
            //Vector3<int> Normalise2 = Vector3<int>.Normalise(nvec2);
            //string Dot2 = Vector3<string>.Dot(nvec2, nvec3);
            //Vector3<string> Cross = Vector3<string>.Cross(nvec2, nvec3);

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

            //Color<double> white = new Color<double>(1.0f, 1.0f, 1.0f, 1.0f);
            //Color<double> black = new Color<double>(1, 1, 1, 1);

            //Color<double> Sum3 = white + black;
            //Color<double> Difference3 = white - black;
            //Color<double> Product3 = white * black;
            //Color<double> Quotient3 = white / black;
            //Color<double> Modulus3 = white % black;
            //float Magnitude3 = Color<float>.Mag(white);
            //Color<float> Normalise3 = Color<float>.Normalise(white);
            //double Dot3 = Color<double>.Dot(white, black);

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
             char[] cHex = { '#', '1', '1', '1', '1', '1', '1' };

             Color<int> hecdec = Color<int>.HexConv(cHex);

             Console.WriteLine("RGBA Values Are: ({0})\n", hecdec);

            Console.ReadLine();

        }
    }

}
