using System;

namespace insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine($"Write ten numbers"); 

            for(int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = int.Parse(Console.ReadLine()); 
            }

            Insertion.InsertionSort(numbers); 

            Console.WriteLine("Sorted numbers"); 

            for(int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }
            
        }
    }

    static class Insertion 
    {
       static public void InsertionSort(int[] array) 
        {
            //debemos iterar por todo el array y chequear si cada item esta en la posicion correcta
            for(int i = 1; i < array.Length; i++) // empezamos en el index 1 porque asumimos que el primero esta en la posicion correcta porque no hay otro item a la izquierda con cual comparar
            {
                // alojamos el valor del inten actual
                int current = array[i]; 
                //nesecitamos otro loop para chequear los items anteriores que debemos mover hacia la derecha, for/while 
                int j = i - 1; // variable del loop, -1 porque empezamos desde el item anterior a i 
                while(j >= 0 && array[j] > current) 
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current; 
            }
        }
    }
}
