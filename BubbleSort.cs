using System;

namespace Sort
{
    class BubbleSort
    {
        public static int[] Sort(int[] arrayToSort) 
        {
            for (int j=0; j<arrayToSort.Length; j++) 
            {
                for (int i=0; i<arrayToSort.Length; i++)
                {
                    if (i != arrayToSort.Length-1) 
                    {
                        int currentElement = arrayToSort[i];
                        int nextElement = arrayToSort[i+1];
                        if (currentElement > nextElement) 
                        {
                            Swap(arrayToSort, i, i+1);
                        }
                    }
                }
            }
            return arrayToSort;
        }

        public static int[] Swap(int[] arrayToSwap, int index1, int index2)
        {
            Console.WriteLine(String.Format("Swapping {0} and {1}", arrayToSwap[index1], arrayToSwap[index2]));
            int tempValue = arrayToSwap[index1];
            arrayToSwap[index1] = arrayToSwap[index2];
            arrayToSwap[index2] = tempValue;
            Console.Write("After swapping: ");
            PrintArray(arrayToSwap);
            return arrayToSwap;
        }

        public static void PrintArray(int[] arrayToPrint){
            for (int i=0; i <arrayToPrint.Length; i++)
            {
                Console.Write(arrayToPrint[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}