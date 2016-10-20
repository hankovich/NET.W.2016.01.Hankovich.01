using System;
using Task01;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array;
            Random rand = new Random();
            Console.Write("Enter length of array: ");
            int length = int.Parse(Console.ReadLine());
            array = new double[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(1000) / 100.0;
            }

            Array.Sort(array);

            for(int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int indexToFind = rand.Next(length); 
            int index = SearchMethods.BinarySearch(array, array[indexToFind]);

            Console.WriteLine(indexToFind + " " + index);
            Console.ReadKey();
        }
    }
}
