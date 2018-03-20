using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Assignment3.Algorithms
{
    public static class QuickSorter
    {
        public static T[] QuickSort<T, TProperty>(T[] unsortedList, int left, int right, Func<T, TProperty> selector)
        {
            if (left < right)
            {
                int pivot = Partition(unsortedList, left, right, selector);
                QuickSort(unsortedList, left, pivot - 1, selector);
                QuickSort(unsortedList, pivot + 1, right, selector);
            }

            return unsortedList;
        }

        private static int Partition<T, TProperty>(T[] unsortedList, int left, int right, Func<T, TProperty> selector)
        {
            T pivot = unsortedList[right];

            int i = left;
            T tempValue; 

            for (int j = left; j < right; j++)
            {
                if (Comparer<TProperty>.Default.Compare(selector(unsortedList[j]), selector(pivot)) <= 0)
                {
                    tempValue = unsortedList[j];
                    unsortedList[j] = unsortedList[i];
                    unsortedList[i] = tempValue;
                    i++;
                }
            }

            unsortedList[right] = unsortedList[i];
            unsortedList[i] = pivot;

            return i;
        }
    }
}
