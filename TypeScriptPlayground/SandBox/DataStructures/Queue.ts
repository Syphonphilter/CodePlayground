import { QueueNode } from "./QueueNode"
// QUEUE USES FIFO
class Queue {
  // Queue properties
  first: QueueNode;
  last: QueueNode;
  length: number;
  constructor(value: any) {
    const newNode = new QueueNode(value);
    this.first = newNode;
    this.last = this.first;
    this.length = 1;
  }
  // Add item to the end of the Queue
  enqueue(value: any) {
    // Create a new Queue node
    let newNode = new QueueNode(value);
    // if queue is empty then point the first item to the node
    if (this.length === 0) {
      this.first = newNode;
    }
    // else similar to the pop method in Linked list but increment
    else {
      // set the next item of the last item to the new node
      this.last.next = newNode;
      // set the last item to the new node
      this.last = this.last.next;
    }
    this.length++;
    return this;
  }

  // remove item form the beginning of the queue
  dequeue() {
    if (this.length == 0) {
      return undefined;
    }

    let temp = this.first;
    this.first = this.first.next;
    temp.next = null;
    this.length--;
    return temp;
  }
}
let myQueue = new Queue(11);
myQueue.enqueue(34);
myQueue.dequeue();
console.log(myQueue);
