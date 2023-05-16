using System;

namespace MyApp 
{
    internal class KokoSort
    {
        static void Main(string[] args)
        {
            int[] arrForSort = { 1, 54, 9, 24, 35, 6, 2};
            int[] arrSortded = new int[arrForSort.Length]; 
            int[] arrSortedIndex = new int[arrForSort.Length];
            for (int i = 0; i < arrForSort.Length; i++)
            {
                int index = 0;
                for (int ii = 0; ii < i; ii++)
                {
                    if (arrForSort[i] > arrForSort[ii])
                    {
                        index ++; 
                    }
                }
                for (int ii = i + 1; ii < arrForSort.Length ; ii++)
                {
                    if (arrForSort[i] > arrForSort[ii])
                    {
                        index++;
                    }
                }
                arrSortedIndex[i] = index;
            }
            for (int i = 0; i < arrSortedIndex.Length; i++)
            {
                arrSortded[arrSortedIndex[i]] = arrForSort[i];
            }
            Console.WriteLine(" ");
        }
    }
}