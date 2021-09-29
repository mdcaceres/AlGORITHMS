using System;

namespace MergeSortWithoutSentinels
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = {12,45,78,96,32,2,1,5};

           Sort.MergeSort(numbers, 0, numbers.Length - 1);

           for(int i = 0; i < numbers.Length; i++)
            Console.Write(numbers[i] + " ");
        }
    }

    static class Sort
    {
        static public void MergeSort(int[] array, int start, int end)
        {
            if(start < end) 
            {
               int mid = (start + end) / 2; 
               MergeSort(array, start, mid);
               MergeSort(array, mid+1, end);
               MergeSortWithOutSentinels(array, start, mid, end); 
            }
        }

        static public void MergeSortWithOutSentinels(int[] array, int start, int mid, int end)
        {
            int n1 = mid - start + 1; 
            int n2 = end - mid; 
            int i, j, k; 

            int[] left = new int[n1]; 
            int[] right = new int[n2]; 

            //en vez de usar un for, se esta usando Array.Copy(source, SourceIndex, destination, destinationIndex, length)
            Array.Copy(array, start, left, 0, n1);
            Array.Copy(array, mid + 1, right, 0, n2);

            // for(i = 0; i < n1; i++)
            //     left[i] = array[start + i]; 

            // for(j = 0; j < n2; j++) 
            //     right[j] = array[end + mid + 1]; 

            i = 0;
            j = 0; 

            for(k = start; k < end + 1; k++) //  <=
            {
                if(i >= n1) // >
                {
                    array[k] = right[j];
                    j++;
                }

                else if(j >= n2) // >
                {
                    array[k] = left[i];
                    i++;
                }

                else if(left[i] <= right[j])
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
    }
}
