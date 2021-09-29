using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {-1,1,2,3,4,8,9,10,12,15,18,20,25,26,31,40,55,60,73,75,114};
            Console.WriteLine(Sort.BinarySearch(numbers, 114));
        }
    }
    static class Sort 
    {
        static public int BinarySearch(int[] array, int target)
        {
            int first = 0; 
            int last = array.Length - 1; 
            while(first <= last)
            {
                int mid = (first + last) / 2; 
                if(array[mid] == target)
                {
                    return target; 
                }
                else if(array[mid] < target)
                {
                    first = mid + 1; 
                }
                else
                {
                    last = mid - 1; 
                }
            }
            return -999; 
        }
    }
}
