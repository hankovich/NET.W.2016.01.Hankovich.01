using System;
using Task01;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            Random rand = new Random();
            Console.Write("Enter length of array: ");
            int length = int.Parse(Console.ReadLine());
            array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(100);
            }

            Array.Sort(array);

            for(int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int indexToFind = rand.Next(length); 
            int index = SearchMethods.BinarySearch(array, array[indexToFind]);

            Console.WriteLine(array[indexToFind] + " " + array[index] + " " + indexToFind + " " + index);
            Console.ReadKey();
        }
    }
}
