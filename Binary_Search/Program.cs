using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    public class BinarySearch
    {
        public int binary_search_iterative(string[] arr, string key)
        {
            int left = 0, right = (arr.Length - 1);
            while (left <= right)                       //Condition Check
            {
                int mid = Math.Abs((left + right) / 2);
                if (arr[mid] == key)
                    return mid;
                else if (key.CompareTo(arr[mid]) > 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
    internal class main
    {
        static void Main(string[] args)
        {
            BinarySearch bs = new BinarySearch();
            string[] arr = { "apple", "ball", "cat", "dog", "egg", "fish" };
            Console.WriteLine("Please enter a string to be searched :");
            string key = Console.ReadLine();
            int result = bs.binary_search_iterative(arr, key);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
