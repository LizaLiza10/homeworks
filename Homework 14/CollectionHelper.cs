using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_14
{
    internal static class CollectionHelper
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            foreach (var item in collection)
            {
                if (condition(item))
                {
                    yield return item;
                }
            }
        }

        public static T FirstOrDefault<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            foreach (var item in collection)
            {
                if (condition(item))
                {
                    return item;
                }
            }

            return default;
        }

        public static bool Any<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            foreach (var item in collection)
            {
                if (condition(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool All<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            foreach (var item in collection)
            {
                if (!condition(item))
                {
                    return false;
                }
            }

            return true;
        }

        public static int Count<T>(this IEnumerable<T> collection)
        {
            int count = 0;

            foreach (var item in collection)
            {
                count++;
            }

            return count;
        }

        public static int Count<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            int count = 0;

            foreach (var item in collection)
            {
                if (condition(item))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
