# Heap-Sort Algorithm

This programming assignment measures the ability to analyze and implement the Heap-Sort algorithm.

---

## Required Algorithms for Heap-Sort

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

## Analyze the Algorithms

### **Heapify Algorithm**:
- **Time Complexity**: O(log n) per call since the height of the heap is proportional to (log n).

### **Build-Max-Heap Algorithm**:
- **Time Complexity**: O(n), as the cost of heapifying nodes decreases for deeper levels (fewer nodes at higher depths).

### **Heap-Sort Algorithm**:
- **Time Complexity**: 
  - **Best Case**: O(n log n), as it involves building the heap and sorting.
  - **Average Case**: O(n log n), due to the heapify operation applied (log n) times per element.
  - **Worst Case**: O(n log n), when the heapify operation requires full reorganization of the heap.

- **Space Complexity**: O(1), since it sorts in-place.
- **Stability**: Heap-Sort is **not stable**, as swapping nodes may disrupt the order of equal elements.

### **Advantages**:
- Consistent worst-case time complexity of O(n log n).
- Does not require extra memory.

### **Disadvantages**:
- Slightly more complex to implement.
- Cache locality is poor due to the non-sequential memory access.

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
# Kruskal's Algorithm - Minimum Spanning Tree (MST)

This programming assignment measures the ability to analyze and implement Kruskal’s Algorithm to find the Minimum Spanning Tree (MST) of a network.

---

## Required Algorithms for Kruskal’s Algorithm

### Steps Involved in Kruskal's Algorithm:
1. **Sort All Edges:**
   - Sort all edges of the graph in non-decreasing order of their weights.

2. **Union-Find Data Structure:**
   - **Find Operation:** Determines the root or representative of a set with path compression for optimization.
   - **Union Operation:** Merges two sets based on rank to maintain efficiency.

3. **Construct MST:**
   - Initialize an empty MST.
   - Iterate through the sorted edges and add each edge to the MST if it does not form a cycle.
   - Use the Union-Find structure to check and avoid cycles.

---

## Analyze the Algorithms

### **Time Complexity:**
1. **Sorting Edges:** O(E log E), where (E) is the number of edges.
2. **Union-Find Operations:** O(E alpha(V)), where (alpha(V)) is the inverse Ackermann function.
3. **Total Complexity:** O(E log E + E alpha(V) approx O(E log E) for most cases.

### **Space Complexity:**
- Union-Find structure: O(V), where (V) is the number of vertices.
- Edge list: O(E).

### **Advantages:**
- Efficient for sparse graphs.
- Straightforward implementation using sorting and Union-Find.

### **Limitations:**
- Sorting step can be expensive for dense graphs.

---

### Example:

Input:
```
Enter the number of vertices:
4
Enter the edges in the format: Source Destination Weight
0 1 10
0 2 6
0 3 5
1 3 15
2 3 4
done
```
Output:
```
Edges in the Minimum Spanning Tree:
(2, 3) - Weight: 4
(0, 3) - Weight: 5
(0, 1) - Weight: 10
Total Weight of the MST: 19
```
