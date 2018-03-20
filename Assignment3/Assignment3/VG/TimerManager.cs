using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Assignment3.Algorithms;

namespace Assignment3.VG
{
    public class TimerManager
    {

        Stopwatch stopWatch;

        public void Generate(int listSize)
        {
            // Generate Random List
            ResetStopWatch();
            var randomList = CreateRandomNumberList(listSize);
            stopWatch.Stop();
            UI.PrintTimer($"Integer list generated (Size: {randomList.Length})", stopWatch.Elapsed);

            // Bubble Sort
            ResetStopWatch();
            BubbleSorter.BubbleSort(randomList);
            stopWatch.Stop();
            UI.PrintTimer($"List sorted with Bubble Sort", stopWatch.Elapsed);

            // Merge Sort
            ResetStopWatch();
            MergeSorter.MergeSort(randomList);
            stopWatch.Stop();
            UI.PrintTimer($"list sorted with Merge Sort", stopWatch.Elapsed);
        }

        private void ResetStopWatch()
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        private int[] CreateRandomNumberList(int listSize)
        {
            var random = new Random();
            var randomList = new List<int>();

            for (int i = 0; i < listSize; i++)
            {
                randomList.Add(random.Next(listSize));
            }
            return randomList.ToArray();
        }

    }
}
