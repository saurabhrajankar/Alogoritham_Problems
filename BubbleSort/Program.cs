using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSort
    {
        public void Bubble_Sort()
        {
            int temp;
            List<int> list = new List<int>() {5, 2, 6, 9, 1};       //Original Elements
            
            Console.WriteLine("The original elements are:");
            foreach (int a in list)
            Console.Write($"{a} ");
            Console.WriteLine();
            for (int j = 0; j < list.Count - 1; j++)                             // this loop for itration
            {
                for (int i = 0; i < list.Count-j-1; i++)                         //this loop for postion
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
            Console.WriteLine("The bubble sorted elements are:");
            foreach (int b in list)
            Console.Write($"{b} ");
            Console.WriteLine();
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Bubble_Sort();
            Console.ReadLine();
        }
    }
}
