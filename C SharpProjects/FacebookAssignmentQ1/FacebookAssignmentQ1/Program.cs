using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAssignmentQ1
{
    class Program
    {

        public static void Range(int num, int num2)
        {

            

            while (num != num2)
            {
                num++;
                if (num % 7 == 0)
                {

                    if (num % 5 != 0)
                    {
                        Console.Write(num + ",");
                    }
                }


            }
        }

        static void Main(string[] args)
        {



            Range(2000, 3200);

            Console.ReadLine();
        }

    }
}
