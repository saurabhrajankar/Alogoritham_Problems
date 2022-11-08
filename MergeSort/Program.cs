using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSort
    {
        //right - r
        //mid - q
        //left - p

        public void Merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }

            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void MergeSort1(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort1(arr, p, q);
                MergeSort1(arr, q + 1, r);
                Merge(arr, p, q, r);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MergeSort merge = new MergeSort();
            int n = 8;
            int[] array = { 49, 3, 53, 21, 27, 75, 50, 41 };
            Console.WriteLine("Merge Sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            merge.MergeSort1(array, 0, n - 1);
            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
