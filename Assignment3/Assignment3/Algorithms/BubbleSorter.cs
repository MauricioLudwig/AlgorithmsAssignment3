using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Algorithms
{
    public static class BubbleSorter
    {
        public static T[] BubbleSort<T>(T[] unsortedList) where T : IComparable
        {
            if (unsortedList.Length <= 1)
            {
                return unsortedList;
            }

            for (int i = 0; i < unsortedList.Length - 1; i++)
            {
                for (int j = 0; j < unsortedList.Length - 1; j++)
                {
                    if (System.Collections.Generic.Comparer<T>.Default.Compare(unsortedList[j], unsortedList[j + 1]) > 0)
                    {
                        var number = unsortedList[j];
                        unsortedList[j] = unsortedList[j + 1];
                        unsortedList[j + 1] = number;
                    }
                }
            }

            return unsortedList;
        }
    }
}