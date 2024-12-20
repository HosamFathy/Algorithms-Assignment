using System;
namespace Heap_Sort
{
class HeapSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers for the array (separated by spaces):");
            string input = Console.ReadLine();

            
            string[] inputArray = input.Split(' ');
            int[] arr = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                arr[i] = int.Parse(inputArray[i]);
            }

            Console.WriteLine("Original array:");
            PrintArray(arr);

            HeapSortAlgorithm(arr);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }

        
        static void Heapify(int[] arr, int n, int i)
        {
            var largest = i;          
            var left = 2 * i + 1;     
            var right = 2 * i + 2;    

            
            if (left < n && arr[left] > arr[largest])
                largest = left;

           
            if (right < n && arr[right] > arr[largest])
                largest = right;

            
            if (largest != i)
            {
                
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                
                Heapify(arr, n, largest);
            }
        }

        
        static void BuildMaxHeap(int[] arr, int n)
        {
            
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);
        }

        
        public static void HeapSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

            BuildMaxHeap(arr, n);

                //Extract elements from the heap one by one
            for (int i = n - 1; i >= 1; i--)
            {
                // Move the current root to the end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Call heapify on the reduced heap
                Heapify(arr, i, 0);
            }
        }
        

        
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }
    }

}
