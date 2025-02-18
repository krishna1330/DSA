using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class SortingTechniques
    {
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }

                SortingTechniques.Swap(arr, min, i);
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool isSwapped = false;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        SortingTechniques.Swap(arr, i, j); ;
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                {
                    break;
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    SortingTechniques.Swap(arr, j, j - 1);
                    j--;
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
