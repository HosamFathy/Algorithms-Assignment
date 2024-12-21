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

This programming assignment measures the ability to analyze and implement Kruskal’s algorithm to find the MST of a network.

---

## Required Algorithms for Kruskal's Algorithm

1. **Kruskal's Algorithm Steps:**
     - Sort all edges in ascending order of weight.
     - Use the Union-Find (Disjoint Set) data structure to manage connected components and detect cycles.
     - Select edges for the MST until ( V-1 ) edges are included, where ( V ) is the number of vertices.
   - **Union-Find Data Structure:**
     - Implements `Find` operation with path compression for efficiency.
     - Implements `Union` operation with rank optimization.

2. **Analyze in detail your written algorithms:**
   - **Time Complexity:**
     - Sorting edges: O(E log E) , where ( E ) is the number of edges.
     - Union-Find operations: O(alpha(V) , where ( alpha ) is the inverse Ackermann function (nearly constant for practical purposes).
     - Total complexity: O(E log E + E alpha(V) approx O(E log E) for most cases.
   - **Space Complexity:**
     - Requires space for storing edges and the Union-Find data structure.
   - **Advantages and Limitations:**
     - Efficient for sparse graphs.
     - Not optimal for dense graphs compared to other MST algorithms like Prim's algorithm.

---

## Features
- **Dynamic Input:** Users can define the graph structure by inputting the vertices and edges at runtime.
- **Union-Find Optimization:** Utilizes the Union-Find data structure with path compression and union by rank for efficient cycle detection.
- **Output:** Displays the edges in the MST and the total weight.

---

## Usage

1. **Enter the number of vertices:**
   - Specify the total number of vertices in the graph.

2. **Input edges in the format:** `Source Destination Weight`
   - Example: `0 1 10` represents an edge from vertex `0` to vertex `1` with a weight of `10`.

3. **Type 'done' to finish adding edges.**

### Sample Input
```
Enter the number of vertices: 4
Enter the edges in the format: Source Destination Weight
Enter an edge (or type 'done' to finish): 0 1 10
Enter an edge (or type 'done' to finish): 0 2 6
Enter an edge (or type 'done' to finish): 0 3 5
Enter an edge (or type 'done' to finish): 1 3 15
Enter an edge (or type 'done' to finish): 2 3 4
Enter an edge (or type 'done' to finish): done
```

### Sample Output
```
Edges in the Minimum Spanning Tree:
(0, 2) - Weight: 6
(0, 3) - Weight: 5
(2, 3) - Weight: 4
Total Weight of the MST: 15
```
