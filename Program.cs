using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString = "Joel";
            var cleanedString = myString.Replace('o','0');


            //dynamic code which represents changing size
            //int.Parse used to parse interger to string
            int classSize = int.Parse(Console.ReadLine());
            int[] ages = new int[classSize];
            
            for (int i = 0; i < classSize; i++)
            {
                Console.WriteLine($"Age of {i} Student?");
                //$ allows for string to be interpolated
                //{i} "called accumulator"
                int age = int.Parse(Console.ReadLine());
                ages[i] = age;
                // or 
                // ages[i] = int.Parse(console.ReadLine());
            }

            string[] myArray = new string[9];
            myArray[0] = "X";
            Console.WriteLine(myArray);
        }
    }
}
