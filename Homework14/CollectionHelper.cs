using System;
using System.Collections.Generic;
using System.Text;

namespace Homework14
{
    internal static class CollectionHelper
    {
        public static void PrintReverse<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection.Reverse())
            {
                Console.WriteLine(item);
            }
        }

        public static T GetFirstElement<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                return item;
            }

            return default;
        }

        public static T GetLastElement<T>(this IEnumerable<T> collection)
        {
            T last = default;

            foreach (var item in collection)
            {
                last = item;
            }

            return last;
        }

        public static bool ContainsElement<T>(this IEnumerable<T> collection, T el)
        {
            foreach (var item in collection)
            {
                if (item.Equals(el))
                {
                    return true;
                }
            }

            return false;
        }

        public static int CountElements<T>(this IEnumerable<T> collection)
        {
            int count = 0;

            foreach (var item in collection)
            {
                count++;
            }

            return count;
        }

        public static int FindIndex<T>(this IEnumerable<T> collection, T el)
        {
            int index = 0;

            foreach (var item in collection)
            {
                if (item.Equals(el))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }


    }
}
