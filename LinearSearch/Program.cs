using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,4,75,3,2,10,12,8,9,15};
            Console.WriteLine(Sort.LinearSearch(1,numbers));
        }
    }

    static class Sort
    {
        static public bool LinearSearch(int number, int[] array)
        {
            for(int i = 0;  i < array.Length; i++)
            {
                if(array[i] == number)
                return true;
            }

            return false; 
        }
    } 
}
