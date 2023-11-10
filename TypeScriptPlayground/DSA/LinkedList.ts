class MyNode{
    value: any;
    next: any;
    constructor(value:any) {
        this.value = value;
        this.next = null;
    }
}
class LinkedList {
    head: MyNode;
    tail: MyNode;
    length: number;

    constructor(value:any) {
        const node = new MyNode(value); 
        this.head = node;
        this.tail = this.head
        this.length = 1;
    }
    push(value:any) {
        const newNode = new MyNode(value)
        if (!this.head) {
            this.head = newNode;
            this.tail = newNode;
        }
        else {
            this.tail.next = newNode
            this.tail = newNode;
        }
        this.length++
        return this;
    }
    printList() {
        let temp = this.head;
        while (temp !== null) {
            console.log(temp.value);
            temp = temp.next;
        }
    }

    getHead() {
        if (this.head === null) {
            console.log("Head: null");
        } else {
            console.log("Head: " + this.head.value);
        }
    }

    getTail() {
        if (this.tail === null) {
            console.log("Tail: null");
        } else {
            console.log("Tail: " + this.tail);
        }
    }

    getLength() {
        console.log("Length: " + this.length);
    }

}


function testLL() {
    let myLinkedList = new LinkedList(7);
    myLinkedList.push(5)
    console.log(myLinkedList)
    myLinkedList.getHead();
    myLinkedList.getTail();
    myLinkedList.getLength();
    console.log("\nLinked List:");
    myLinkedList.printList();
}


testLL();
