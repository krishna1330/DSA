using DSA;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 32, 14, 1, 78, 40 };

            SortingTechniques.SelectionSort(arr);
            SortingTechniques.BubbleSort(arr);
            SortingTechniques.InsertionSort(arr);
            SortingTechniques.MergeSort(arr, 0, arr.Length - 1);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}