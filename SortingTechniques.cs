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
        }

        public static void MergeSort(int[] arr, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int mid = (low + high) / 2;

            SortingTechniques.MergeSort(arr, 0, mid);
            SortingTechniques.MergeSort(arr, mid + 1, high);

            SortingTechniques.MergeArray(arr, low, mid, high);
        }

        public static void MergeArray(int[] arr, int low, int mid, int high)
        {
            int left = low;
            int right = mid + 1;

            List<int> list = new List<int>();

            while (left <= mid && right <= high)
            {
                if (arr[left] < arr[right])
                {
                    list.Add(arr[left]);
                    left++;
                }
                else
                {
                    list.Add(arr[right]);
                    right++;
                }
            }

            while (left <= mid)
            {
                list.Add(arr[left]);
                left++;
            }

            while (right <= high)
            {
                list.Add(arr[right]);
                right++;
            }

            for (int i = low; i <= high; i++)
            {
                arr[i] = list[i - low];
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
