using System;
using System.Collections.Generic;
using System.Text;

namespace homework10
{
    internal class CustomArray : IOuput2, ICalc2cs
    {
        int[] array = [45, 62, 35, 78, 92, 78, 78];
        public void ShowEven()
        {
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void ShowOdd()
        {
            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }

        }


        public int CountDistinct()
        {

            int countdistinct = 0;
            foreach (var item in array) 
            {
                int count = 0;
                foreach (var item1 in array)
                {
                    if (item == item1)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    countdistinct++;
                }
            }

            return countdistinct;

        }

        public int EqualToValue(int x)
        {
            foreach (var item in array)
            {
                if (x == item)
                {
                    return item;
                }
            }
            return default;
        }
    }
}
