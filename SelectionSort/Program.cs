using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = {1,4,75,3,2,10,12,8,9,15};
           Sort.SelectionSort(numbers);

           for(int i = 0; i < numbers.Length; i++)
           {
               Console.WriteLine(numbers[i]);
           }
        }
    }

    static public class Sort 
    {
        static public void SelectionSort(int[] array) 
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int minValue = i;

                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[minValue] && j != minValue) {
                        minValue = j;
                    }
                } 

                int temp = array[i];
                array[i] = array[minValue]; 
                array[minValue] = temp; 
            }
        }
    }
}
