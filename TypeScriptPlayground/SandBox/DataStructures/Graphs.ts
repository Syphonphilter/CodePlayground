class Graphs {
    adjacencyList: { [key: string]: string[] };
    constructor() {
        this.adjacencyList={}
    }
    /**
     * Adds a new vertex to the graph's adjacency list if it doesn't already exist.
     * @param vertex - The vertex to be added to the graph.
     * @returns True if the vertex was successfully added, false if it already exists.
     */
    addVertex(vertex: any): boolean {
      if (!this.adjacencyList[vertex]) {
        this.adjacencyList[vertex] = [];
        return true;
      }
      return false;
    }

    /**
     * Adds an edge between two vertices in the graph's adjacency list.
     * @param vertex1 The first vertex of the edge.
     * @param vertex2 The second vertex of the edge.
     * @returns True if the edge was successfully added, false otherwise.
     */
    addEdge(vertex1: any, vertex2: any): boolean {
        if (this.adjacencyList[vertex1] && this.adjacencyList[vertex2]) {
            if (this.adjacencyList[vertex1].filter(v => v === vertex2).length == 0) {
                this.adjacencyList[vertex1].push(vertex2);
                this.adjacencyList[vertex2].push(vertex1);
                return true;
            }
      }
      return false;
    }
    /**
     * Removes an edge between two vertices in the graph's adjacency list.
     * @param vertex1 - The first vertex of the edge.
     * @param vertex2 - The second vertex of the edge.
     * @returns True if the edge was successfully removed, false otherwise.
     */
    removeEdge(vertex1: any, vertex2: any): boolean {
      if (this.adjacencyList[vertex1] && this.adjacencyList[vertex2]) {
        this.adjacencyList[vertex1] = this.adjacencyList[vertex1].filter(v => v !== vertex2);
        this.adjacencyList[vertex2] = this.adjacencyList[vertex2].filter(v => v !== vertex1);
        return true;
      }
      return false;
    }
    removeVertex(vertex: any) {
        if (!this.adjacencyList[vertex]) return undefined
        while (this.adjacencyList[vertex].length) {
            let temp = this.adjacencyList[vertex].pop()
            this.removeEdge(vertex,temp)
        
        }
        delete this.adjacencyList[vertex]
        return this
    }

}
const myEdge = new Graphs
myEdge.addVertex("A")
myEdge.addVertex("B")
myEdge.addVertex("C")
myEdge.addVertex("D")
myEdge.addEdge("A","B")
myEdge.addEdge("A","C")
myEdge.addEdge("A","D")
myEdge.addEdge("B","C")
myEdge.addEdge("B","D")
myEdge.addEdge("C","D")
myEdge.removeVertex("D")
console.log(myEdge)


