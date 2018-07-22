using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[10] {3, 7, 5, 1, 8, 25, 18, 6, 9, 2};
            Console.Write("Unsorted array: ");
            BubbleSort.PrintArray(unsortedArray);

            int[] sortedArray = BubbleSort.Sort(unsortedArray);
            Console.Write("\nSorted array: ");
            BubbleSort.PrintArray(sortedArray);
        }
    }
}
