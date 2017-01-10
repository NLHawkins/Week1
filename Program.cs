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
            string[] board =
            {
                "_","_","_","_","_","_","_","_","_",
            };
            int counter = 0;
            foreach(string place in board)
            {
                if (counter== 3)
                {
                    Console.WriteLine("");
                    Console.Write("_ " + place);
                    counter = 1;
                
                }
                else
                {
                    Console.Write("_" + place);
                    counter++;
                }
            }


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

                if (i == 2)
                {
                    Console.WriteLine("Magic Johnson");
                }

                else if (i== 3)
                {
                    Console.WriteLine("Unlucky Person");
                }
            }
            //to list each age
            foreach(var age in ages)
            {
                string readableDrinkAge;
                bool isLegalToDrink = age >= 21;
                if (isLegalToDrink)
                {
                    readableDrinkAge = "Yes";
                }
                else
                {
                    readableDrinkAge = "No";
                }
             
                //shown in ternary style

                
                
                Console.WriteLine($"{age} is legal to drink? {readableDrinkAge}");
                   
            }
            //method max on array(ages)
            Console.WriteLine("--------");
            Console.WriteLine(ages.Max());
            Console.WriteLine(ages.Min());
            Console.WriteLine(ages.Average());

            string[] myArray = new string[9];
            myArray[0] = "X";
            Console.WriteLine(myArray);
        }
    }
}
