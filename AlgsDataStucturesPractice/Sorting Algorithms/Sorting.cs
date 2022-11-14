using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDataStucturesPractice
{
    internal class Sorting
    {
        public Sorting()
        {

        }

        public string merge_sort(int[] arr, int left, int right)
        {
            return "";
            int[] merge_halves(int[] arr1, int[] arr2)
            {
                int ind1 = 0;
                int ind2 = 0;
                int indM = 0;
                int[] merged = new int[arr1.Length + arr2.Length];

                while (ind1 < arr1.Length && ind2 < arr2.Length)
                {
                    if (arr1[ind1] >= arr2[ind2])
                    {
                        merged[indM] = arr1[ind1];
                        ind1++;
                        indM++;
                    }
                    else
                    {
                        merged[indM] = arr2[ind2];
                        ind2++;
                        indM++;
                    }
                }
                if (ind1 < arr1.Length)
                {
                    while (ind1 < arr1.Length)
                    {
                        merged[indM] = arr1[ind1];
                        ind1++;
                        indM++;
                    }
                }
                if (ind2 < arr2.Length)
                {
                    while (ind2 < arr2.Length)
                    {
                        merged[indM] = arr2[ind2];
                        ind2++;
                        indM++;
                    }
                }
                return merged;
            }

        }

        public string insertion_sort(int[] arr)
        {
            return "";
        }

        public int[] quick_sort(int[] arr)
        {
            return arr;
        }

        public string bubble_sort(int[] arr)
        {
            int x;
            int y;
            int index;
            bool changed = true;
            while (changed != false)
            {
                changed = false;
                for (index = 0; index < arr.Length - 1; index++)
                {
                    x = arr[index];
                    y = arr[index + 1];
                    if (x > y)
                    {
                        arr[index] = y;
                        arr[index + 1] = x;
                        changed = true;
                    }
                }
            }
            return(string.Join(" ", arr));

        }

        public int[] heap_sort(int[] arr)
        {
            return arr;
        }

        public string counting_sort(int[] arr)
        {
            return "";
        }
    }
}
