using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
             Program12b();
        }

        private static void Program1()
        {
            Console.WriteLine("Hello");
        }

        private static void Program2()
        {
            string name;
            name = "Margulan";
            Console.WriteLine(name);
        }

        private static void Program3()
        {
            string name = "Margulan";
            Console.WriteLine("Hello Margulan");
            string h = "Hello " + name;
            Console.WriteLine(h);
            String s = String.Format("Hello {0}", name);
            Console.WriteLine(s);
            Console.WriteLine($"Hello {name}");

        }

        private static void Program4()
        {
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }

        private static void Program5()
        {
            var radius = Convert.ToDouble(Console.ReadLine());
            var area = radius * radius * Math.PI;
            Console.WriteLine(area);

        }

        private static void Program6()
        {
            var radius = Convert.ToDouble(Console.ReadLine());
            var area = radius * radius * Math.PI;
            var circumference = 2 * radius * Math.PI;
            Console.WriteLine($"Circumference is {circumference}");
            Console.WriteLine($"Area is {area}");
        }

        private static void Program7()
        {
            Console.WriteLine("Enter height and base of triangle");
            var height = Convert.ToDouble(Console.ReadLine());
            var basee = Convert.ToDouble(Console.ReadLine());
            var area = height * basee * 0.5;
            Console.WriteLine($"Area is {area}");

        }

        private static void Program8()
        {
            Console.WriteLine("Enter sides of triangle");
            var first = Convert.ToDouble(Console.ReadLine());
            var second = Convert.ToDouble(Console.ReadLine());
            var third = Convert.ToDouble(Console.ReadLine());

            var circumference = first + second + third;
            var halfOfCircumference = circumference / 2;
            var area = Math.Sqrt(halfOfCircumference * (halfOfCircumference - first) * (halfOfCircumference - second) *
                                 (halfOfCircumference - third));
            Console.WriteLine($"Area is {area}");
            Console.WriteLine($"Circumference is {circumference}");

        }

        private static void Program9()
        {
            Console.WriteLine("Please give temperatures in Celsius");
            var tempInput = Console.ReadLine();
            var temp = Convert.ToDouble(tempInput);
            var fahrenheit = 9 / 5 * temp + 32;
            var kelvin = temp + 273.15;
            Console.WriteLine($"Fahrenheit is {fahrenheit} F");
            Console.WriteLine($"Kelvin is {kelvin} K");

        }

        private static void Program10a()
        {
            Console.WriteLine("Enter 4 numbers");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());

            var sum = a + b + c + d;
            var average = sum / 4;
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Average is {average}");

        }

        private static void Program10b()
        {
            Console.WriteLine("Enter 4 numbers");
            var myArray = new int[4];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            var sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            var average = 1.0 * sum / myArray.Length;
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Average is {average}");
        }

        private static void Program10c()
        {
            Console.WriteLine("Enter 4 numbers");
            var myList = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                myList.Add(Convert.ToInt32(Console.ReadLine()));

            }

            var sum = 0;

            for (int i = 0; i < myList.Count; i++)
            {
                sum += myList[i];
            }

            var average = 1.0 * sum / myList.Count;
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Average is {average}");


        }

        private static void Program11a()
        {
            Console.WriteLine("Enter how many numbers you will enter");
            var inputNumbers = Convert.ToInt32(Console.ReadLine());
            var myArray = new int[inputNumbers];
            for (var i = 0; i < inputNumbers; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            var sum = myArray.Sum();
            var average = myArray.Average();

            Console.WriteLine($"Amount of numbers are {inputNumbers}");
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Average is {average}");



        }

        private static void Program11b()
        {
            Console.WriteLine("Enter how many numbers you will enter");
            var inputOfnumbers = Convert.ToInt32(Console.ReadLine());
            var myList = new List<int>();
            for (var i = 0; i < inputOfnumbers; i++)
            {
                myList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var sum = myList.Sum();
            var average = myList.Average();

            Console.WriteLine($"Input numbers = {inputOfnumbers}");
            Console.WriteLine($"Sum is {sum}");
            Console.Write($"Average is {average}");
        }

        private static void Program12b()
        {
            Console.WriteLine("Enter some number or numbers");
            var myArray = new int[1000];
             
            int i = 0;
            int n = 0;
            int input = 0;
            while (i<myArray.Length)
            {
                
                string number = Console.ReadLine();
                if (number != null)
                {
                     Int32.TryParse(number, out input);
                     myArray[i] = input;
                     Console.WriteLine(input);
                     i++;
                     
                }
                
                
                 if (string.IsNullOrWhiteSpace(number))
                {   
                    Console.WriteLine($"Max = {myArray.Max()}");
                    Console.WriteLine($"Min = {myArray.Min()}");
                    Console.WriteLine($"Average = {myArray.Average()}");
                    Console.WriteLine($"Count = {i}");
                    break;
                }

                
               






            }
               
                  
           
            
        }
    }
}
