using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3.Algorithms
{
    public static class MergeSorter
    {
        public static T[] MergeSort<T>(T[] unsortedList)
        {
            if (unsortedList.Length <= 1)
            {
                return unsortedList;
            }

            var left = new List<T>();
            var right = new List<T>();

            for (int i = 0; i < unsortedList.Length; i++)
            {
                if (i % 2 > 0)
                {
                    left.Add(unsortedList[i]);
                }
                else
                {
                    right.Add(unsortedList[i]);

                }
            }

            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

            return Merge(left, right);
        }

        private static T[] Merge<T>(List<T> left, List<T> right)
        {
            var mergedList = new List<T>();

            while (ListNotEmpty(left) && ListNotEmpty(right))
            {
                if (Comparer<T>.Default.Compare(left.First(), right.First()) < 0 || Comparer<T>.Default.Compare(left.First(), right.First()) == 0)
                {
                    AddToMergedList(left, mergedList);
                }
                else
                {
                    AddToMergedList(right, mergedList);
                }
            }

            while (ListNotEmpty(left))
            {
                AddToMergedList(left, mergedList);
            }

            while (ListNotEmpty(right))
            {
                AddToMergedList(right, mergedList);
            }

            return mergedList.ToArray();
        }

        private static bool ListNotEmpty<T>(List<T> list)
        {
            return list.Count > 0;
        }

        private static void AddToMergedList<T>(List<T> list, List<T> mergedList)
        {
            mergedList.Add(list.First());
            list.RemoveAt(0);
        }
    }
}
