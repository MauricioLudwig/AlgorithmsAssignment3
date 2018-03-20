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
            T pivot = unsortedList[left];

            while (true)
            {
                while (Comparer<TProperty>.Default.Compare(selector(unsortedList[left]), selector(pivot)) < 0)
                {
                    left++;
                }

                while (Comparer<TProperty>.Default.Compare(selector(unsortedList[right]), selector(pivot)) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (Comparer<TProperty>.Default.Compare(selector(unsortedList[left]), selector(unsortedList[right])) == 0)
                    {
                        return right;
                    }

                    T temp = unsortedList[left];
                    unsortedList[left] = unsortedList[right];
                    unsortedList[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
