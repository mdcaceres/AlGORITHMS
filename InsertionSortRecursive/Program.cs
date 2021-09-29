using System;

namespace InsertionSortRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = {5,2,4,6,1,3};

           Sort.RecursiveInsertionSort(numbers, numbers.Length);

           for(int i = 0; i < numbers.Length; i++)
           {
               Console.WriteLine(numbers[i]);
           }
        }
    }

    static public class Sort 
    {
        static public void RecursiveInsertionSort(int[] array, int length)
        {
            if(length <= 1)
            {
                return; 
            }

            RecursiveInsertionSort(array, length - 1);

            int current = array[length - 1];
            int prev = length - 2; 

            while(prev >= 0 && array[prev] > current)
            {
                array[prev + 1] = array[prev];
                prev--;
            }
            array[prev + 1] = current; 
        }
    }
}
