//* CPU CLUSTERING
const cluster = require('cluster'); // Import the 'cluster' module for handling clustering.
const numCPUs = require('os').cpus().length; // Determine the number of CPU cores available.

if (cluster.isMaster) { // Check if this is the master process.
  // Create a worker for each CPU core
  for (let i = 0; i < 2; i++) {
    cluster.fork(); // Create a new child worker process for each CPU core.
  }

  cluster.on('exit', (worker:any, code:any, signal:any) => {
    console.log(`Worker ${worker.process.pid} died`); // Log when a worker process dies.
  });
} else { // This code is executed by worker processes.
  // CPU-bound task: Calculate Fibonacci numbers
  const calculateFibonacci=(n:number):number=> {
    if (n <= 1) {
      return n; // Base case for Fibonacci sequence.
    } else {
      return calculateFibonacci(n - 1) + calculateFibonacci(n - 2); // Recursive calculation.
    }
  }

  const n = 40; // The Fibonacci number to calculate (can be time-consuming for large 'n').
  const result = calculateFibonacci(n); // Perform the CPU-bound task.
  console.log(`Worker ${process.pid} calculated Fibonacci(${n}): ${result}`); // Log the result.

  // Worker process exits after completing its task.
  process.exit(0);
}