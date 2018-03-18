using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Algorithms
{
    public static class QuickSorter
    {
        public static T[] QuickSort<T>(T[] unsortedList, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(unsortedList, left, right);
                QuickSort(unsortedList, left, pivot - 1);
                QuickSort(unsortedList, pivot + 1, right);
            }

            return unsortedList;
        }

        private static int Partition<T>(T[] unsortedList, int left, int right)
        {
            T pivot = unsortedList[left];

            while (true)
            {
                while (Comparer<T>.Default.Compare(unsortedList[left], pivot) < 0)
                {
                    left++;
                }

                while (Comparer<T>.Default.Compare(unsortedList[right], pivot) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (Comparer<T>.Default.Compare(unsortedList[left], unsortedList[right]) == 0)
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
