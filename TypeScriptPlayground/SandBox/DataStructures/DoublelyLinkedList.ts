import { DoubleListNode } from "./DoubleListNode"

class DoublelyLinkedList {
    head: DoubleListNode
    tail: DoubleListNode
    listLength: number
    
    constructor(value: any) {
        const node = new DoubleListNode(value,)
        this.head = node
        this.tail = this.head
        this.listLength = 1;
    }
}