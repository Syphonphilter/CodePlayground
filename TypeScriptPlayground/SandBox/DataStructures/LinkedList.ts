import { boolean } from "ts-pattern/dist/patterns"
import { ListNode } from "./ListNode"

class LinkedList{
    head: ListNode 
    tail:ListNode
    listLength: number
    
    constructor(value: any) {
        const node = new ListNode(value,)
        this.head = node
        this.tail=this.head
        this.listLength = 1;
    }
    push(value: any) {
        const new_node = new ListNode(value,)
        if (!this.checkEdgeCase) {
            this.head = new_node
            this.tail = this.head
        }
        else {
            this.tail.next = new_node;
            this.tail = new_node;
        }

        this.listLength += 1;
        return this
    }
    unshift(value: any) {
        
    }
    insert(value: any, index:number) {
        
    }
    pop() {
        let emptyNode = new ListNode(null)
        let temp = this.head
        let pre = temp
        if (this.checkEdgeCase(this.head, this.tail)) {
            while (temp.next) {
                pre = temp
                temp = temp.next
            }
            this.tail = pre;
            this.tail.next = new ListNode(null)
            this.listLength--
            if (this.listLength == 0) {
                this.head = emptyNode
                this.tail = emptyNode
            }   
        }
        return temp
    }
    checkEdgeCase(head: ListNode, tail: ListNode,ispop?:boolean): boolean{
        let returnStatus: boolean = false;
        if (!this.head) {

            returnStatus = false;
        }
        if (ispop)
        {
            this.listLength == 1 ? returnStatus = false : returnStatus = true;   
        }
        return returnStatus;
    }
}
let list = new LinkedList(1);
list.push(2)
list.push(3)
list.push(4)
list.pop()

console.log(list)