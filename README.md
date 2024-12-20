# Algorithms-Assignment
# Heap-Sort Algorithm: Programming Assignment

This programming assignment measures the ability to analyze and implement the Heap-Sort algorithm.

---

## Part (a): Write All Required Algorithms for Heap-Sort

### Steps Involved in Heap-Sort:
1. **Heapify Algorithm**:
   Maintains the max-heap property for a subtree rooted at a given index. Ensures the largest value is at the root.

   ```
   Heapify(arr, n, i):
       largest = i               # Initialize largest as root
       left = 2 * i + 1          # Left child index
       right = 2 * i + 2         # Right child index

       if left < n and arr[left] > arr[largest]:
           largest = left

       if right < n and arr[right] > arr[largest]:
           largest = right

       if largest != i:
           Swap(arr[i], arr[largest])
           Heapify(arr, n, largest)
   ```

2. **Build-Max-Heap Algorithm**:
   Converts an unsorted array into a max-heap.

   ```
   BuildMaxHeap(arr):
       n = len(arr)
       for i from (n // 2 - 1) to 0:  # Start from last non-leaf node
           Heapify(arr, n, i)
   ```

3. **Heap-Sort Algorithm**:
   Sorts the array by repeatedly extracting the maximum element.

   ```
   HeapSort(arr):
       BuildMaxHeap(arr)          # Step 1: Build the max-heap
       n = len(arr)
       for i from (n - 1) to 1:
           Swap(arr[0], arr[i])   # Move max element to end
           Heapify(arr, i, 0)     # Reduce the heap size and heapify
   ```

---

## Part (b): Analyze the Algorithms

### **Heapify Algorithm**:
- **Time Complexity**: \(O(\log n)\) per call since the height of the heap is proportional to \(\log n\).

### **Build-Max-Heap Algorithm**:
- **Time Complexity**: \(O(n)\), as the cost of heapifying nodes decreases for deeper levels (fewer nodes at higher depths).

### **Heap-Sort Algorithm**:
- **Time Complexity**: 
  - **Best Case**: \(O(n \log n)\), as it involves building the heap and sorting.
  - **Average Case**: \(O(n \log n)\), due to the heapify operation applied \(\log n\) times per element.
  - **Worst Case**: \(O(n \log n)\), when the heapify operation requires full reorganization of the heap.

- **Space Complexity**: \(O(1)\), since it sorts in-place.
- **Stability**: Heap-Sort is **not stable**, as swapping nodes may disrupt the order of equal elements.

### **Advantages**:
- Consistent worst-case time complexity of \(O(n \log n)\).
- Does not require extra memory.

### **Disadvantages**:
- Slightly more complex to implement.
- Cache locality is poor due to the non-sequential memory access.

---

## Part (c): Implementation

### C# Implementation:
```csharp
using System;

class HeapSort
{
    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

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

    static void BuildMaxHeap(int[] arr)
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);
    }

    public static void HeapSortAlgorithm(int[] arr)
    {
        BuildMaxHeap(arr);
        int n = arr.Length;
        for (int i = n - 1; i >= 1; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the numbers for the array (separated by spaces):");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int[] arr = Array.ConvertAll(inputArray, int.Parse);

        Console.WriteLine("Original array:");
        PrintArray(arr);

        HeapSortAlgorithm(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
```

### Example:
Input:
```
Enter the numbers for the array (separated by spaces):
12 11 13 5 6 7
```
Output:
```
Original array:
12 11 13 5 6 7 

Sorted array:
5 6 7 11 12 13
```

---

This README provides a complete guide for understanding, analyzing, and implementing the Heap-Sort algorithm as part of the assignment.

