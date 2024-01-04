import { QueueNode } from "./QueueNode";

class Queue{
    first: QueueNode
    last: QueueNode
    length: number
    constructor(value:any) {
        const newNode = new QueueNode(value);
        this.first = newNode;
        this.last = this.first
        this.length =1
        
    }
    enqueue(value: any) {
        let newNode = new QueueNode(value)
        if (this.length === 0) {
            this.first = newNode;
        }
        else {
            this.last.next = newNode;
            this.last = this.last.next;
        }
        this.length++
        return this
        
    }
    dequeue() {
        if (this.length === 0) {
            return undefined;
        }
     
            let temp = this.first
            this.first = this.first.next;
            temp.next = null
        this.length--
        return temp

        
    }
    
}
let myQueue = new Queue(11)
myQueue.enqueue(34)
myQueue.dequeue()
console.log(myQueue)