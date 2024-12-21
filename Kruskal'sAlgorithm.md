# Kruskal's Algorithm - Minimum Spanning Tree (MST)

This repository contains a C# implementation of Kruskal's Algorithm to find the Minimum Spanning Tree (MST) of a graph. The program allows users to dynamically input the graph's vertices and edges.

---

## Assignment Description

This programming assignment measures the ability to analyze and implement Kruskal’s algorithm to find the MST of a network. The task is designed to be completed as teamwork (Maximum Two–Three members). The requirements are as follows:

### Tasks:

1. **Write all required algorithms needed to find MST using Kruskal’s Algorithm:**
   - **Kruskal's Algorithm Steps:**
     - Sort all edges in ascending order of weight.
     - Use the Union-Find (Disjoint Set) data structure to manage connected components and detect cycles.
     - Select edges for the MST until \( V-1 \) edges are included, where \( V \) is the number of vertices.
   - **Union-Find Data Structure:**
     - Implements `Find` operation with path compression for efficiency.
     - Implements `Union` operation with rank optimization.

2. **Analyze in detail your written algorithms:**
   - **Time Complexity:**
     - Sorting edges: \( O(E \log E) \), where \( E \) is the number of edges.
     - Union-Find operations: \( O(\alpha(V)) \), where \( \alpha \) is the inverse Ackermann function (nearly constant for practical purposes).
     - Total complexity: \( O(E \log E + E \alpha(V)) \approx O(E \log E) \) for most cases.
   - **Space Complexity:**
     - Requires space for storing edges and the Union-Find data structure.
   - **Advantages and Limitations:**
     - Efficient for sparse graphs.
     - Not optimal for dense graphs compared to other MST algorithms like Prim's algorithm.

3. **Implement your written algorithms:**
   - The implementation allows dynamic input from users to define vertices and edges.

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

