using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Algorithms
{
    public class SortManager
    {
        public int[] BubbleSortMethod(int[] unsortedList)
        {
            return BubbleSorter.BubbleSort(unsortedList);
        }

        public char[] BubbleSortMethod(char[] unsortedList)
        {
            return BubbleSorter.BubbleSort(unsortedList);
        }

        public int[] MergeSortMethod(int[] unsortedList)
        {
            return MergeSorter.MergeSort(unsortedList);
        }

        public char[] MergeSortMethod(char[] unsortedList)
        {
            return MergeSorter.MergeSort(unsortedList);
        }

        public int[] QuickSortMethod(int[] unsortedList)
        {
            return QuickSorter.QuickSort(unsortedList, 0, unsortedList.Length - 1);
        }

        public char[] QuickSortMethod(char[] unsortedList)
        {
            return QuickSorter.QuickSort(unsortedList, 0, unsortedList.Length - 1);
        }
    }
}
