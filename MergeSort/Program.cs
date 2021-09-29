using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {12,45,78,96,32,2,1,5};

            Sort.MergeSort(array, 0, array.Length - 1);

            for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
        }
    }

    static public class Sort 
    {
        static public void Merge(int[] array, int start, int mid, int end)
        {
            int n1 = mid - start + 1; 
            int n2 = end - mid;
            
            int[] left = new int[n1 + 1];
            int[] right = new int[n2 + 1];

            int i, j; 

            for(i = 0; i < n1; i++) 
            {
                left[i] = array[start + i];
            }

            for(j = 0; j < n2; j++)
            {
                right[j] = array[mid + j + 1];
            }

            left[n1] = Int32.MaxValue; 
            right[n2] = Int32.MaxValue;

            i = 0;
            j = 0; 

           for(int k = start; k <= end; k++)
           {

            if(left[i] <= right[j])
               {
                   array[k] = left[i];
                   i++;
               } 
               else 
               {
                   array[k] = right[j]; 
                   j++;
               }
           }  

        }

        static public void MergeSort(int[] array, int start, int end)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;
                MergeSort(array, start, mid);
                MergeSort(array, mid+1, end);
                Merge(array, start, mid, end); 
            }
        }

    }

}
