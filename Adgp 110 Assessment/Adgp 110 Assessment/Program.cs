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
    
            Vector2<float> nvec = new Vector2<float>(5.2f, 5.0f);
            Vector2<float> nvec1 = new Vector2<float>(5.0f, 5.2f);

            
            Vector2<float> Sum = nvec + nvec1;
            Vector2<float> Difference = nvec - nvec1;
            Vector2<float> Product = nvec * nvec1;
            Vector2<float> Quotient = nvec / nvec1;
            Vector2<float> Modulus = nvec % nvec1;
            float Magnitude = Vector2<float>.Mag(nvec1);
            Vector2<float> Normalise = Vector2<float>.Normalise(nvec1);
            float Dot = Vector2<float>.Dot(nvec, nvec1);

            Console.WriteLine("Vector 2 Math: ");
            Console.WriteLine("Sum is: ({0})", Sum);
            Console.WriteLine("Difference is: ({0})", Difference);
            Console.WriteLine("Product is: ({0})", Product);
            Console.WriteLine("Quotient is: ({0})", Quotient);
            Console.WriteLine("Modulus is: ({0})", Modulus);
            Console.WriteLine("Magnitude is: ({0})", Magnitude);
            Console.WriteLine("Normalised is: ({0})", Normalise);
            Console.WriteLine("Dot Product is: ({0})", Dot);



            Vector3<int> nvec2 = new Vector3<int>(1, 2, 3);
            Vector3<int> nvec3 = new Vector3<int>(1, 2, 3);

            int mag = Vector3<int>.Mag(nvec2);
            Vector3<int> Sum2 = nvec2 + nvec3;
            Vector3<int> Difference2 = nvec2 - nvec3;
            Vector3<int> Product2 = nvec2 * nvec3;
            Vector3<int> Quotient2 = nvec2 / nvec3;
            Vector3<int> Modulus2 = nvec2 % nvec3;
            int Magnitude2 = Vector3<int>.Mag(nvec2);
            Vector3<int> Normalise2 = Vector3<int>.Normalise(nvec2);
            int Dot2 = Vector3<int>.Dot(nvec2, nvec3);
            Vector3<int> Cross = Vector3<int>.Cross(nvec2, nvec3);

            Console.WriteLine("\nVector 3 Math: ");
            Console.WriteLine("Sum is: ({0})", Sum2);
            Console.WriteLine("Difference is: ({0})", Difference2);
            Console.WriteLine("Product is: ({0})", Product2);
            Console.WriteLine("Quotient is: ({0})", Quotient2);
            Console.WriteLine("Modulus is: ({0})", Modulus2);
            Console.WriteLine("Magnitude is: ({0})", Magnitude2);
            Console.WriteLine("Normalised is: ({0})", Normalise2);
            Console.WriteLine("Dot Product is: ({0})", Dot2);
            Console.WriteLine("Cross Product is: ({0})", Cross);



            Color<double> white = new Color<double>(1.0f, 1.0f, 1.0f, 1.0f);
            Color<double> black = new Color<double>(1.0f, 1.0f, 1.0f, 1.0f);

            Color<double> Sum3 = white + black;
            Color<double> Difference3 = white - black;
            Color<double> Product3 = white * black;
            Color<double> Quotient3 = white / black;
            Color<double> Modulus3 = white % black;
            double Magnitude3 = Color<double>.Mag(white);
            Color<double> Normalise3 = Color<double>.Normalise(white);
            double Dot3 = Color<double>.Dot(white, black);

            Console.WriteLine("\nColor Math: ");
            Console.WriteLine("Sum is: ({0})", Sum3);
            Console.WriteLine("Difference is: ({0})", Difference3);
            Console.WriteLine("Product is: ({0})", Product3);
            Console.WriteLine("Quotient is: ({0})", Quotient3);
            Console.WriteLine("Modulus is: ({0})", Modulus3);
            Console.WriteLine("Magnitude is: ({0})", Magnitude3);
            Console.WriteLine("Normalised is: ({0})", Normalise3);
            Console.WriteLine("Dot Product is: ({0})", Dot3);

            //Create An Array For Storing The Input Variables From The User
            char[] cHex = { '#', '1', '1', '1', '1', '1', '1' };

             Color<int> hecdec = Color<int>.HexConv(cHex);

             Console.WriteLine("RGBA Values Are: ({0})\n", hecdec);

            Console.ReadLine();

        }
    }

}
