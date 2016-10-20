using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public static class SearchMethods
    {
        /// <summary>
        /// Find a element in a sorted array by the binary search.
        /// </summary>
        /// <param name="array">Sorted array of any data type, which implements interface IComparable.</param>
        /// <param name="element">The value of the element you wan't to find.</param>
        /// <returns>The index of the first occurrence or -1, when element is not present in array.</returns>
        public static int BinarySearch<T>(T[] array, T element)
            where T : IComparable <T>
        {
            int begin = 0, end = array.Length - 1;
            if (array.Length == 0
                || array[begin].CompareTo(element) == 1
                || array[end].CompareTo(element) == -1)
            {
                return -1;
            }

            while (begin < end)
            {
                int med = begin + (end - begin) / 2;
                if (array[med].CompareTo(element) == -1)
                {
                    begin = med + 1;
                }
                else
                {
                    end = med;
                }
            }
            if (array[end].CompareTo(element) == 0)
            {
                return end;
            }
            else
            {
                return -1;
            }
        }

    }
}
