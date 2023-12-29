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

        this.listLength ++;
        return this
    }
    // add to the first element
    unshift(value: any) {
        let node = new ListNode(value)
        if (!this.checkEdgeCase()) {
            this.head = node
            this.tail = this.head
        }
        else {
            node.next = this.head
            this.head = node
        }
        this.listLength++
        return this
        
    }

    // remove the first element
    shift()
    {
        //temp = head
        let temp = this.head
        //check for edge cases
        if (this.checkEdgeCase()) {
            // if there is an edge case set head to null
            this.head = new ListNode(null)
        }
        else {
            // set the head to the next node
            this.head = this.head.next
            //remove the connection between temp and head
            temp.next = null
        
            this.listLength--
        }
        if (this.listLength === 0) {
            //if the resulting deduction results to an empty list, set tail to null
            this.tail= new ListNode(null)
        }
        return this
    }
    remove(index: number) {
        if (index === 0) return  this.shift()
        if (index > this.listLength) return  false
        if (index === this.listLength-1|| this.listLength=== 0) return this.pop();
        if (index < 0 || index > this.listLength) return false;
        let temp = this.get(index - 1)
        let origin = temp.next
        temp.next = origin.next
        origin.next = null
        this.listLength--
        return temp
    }

    //insert node into a given index
    insert(value: any, index: number) {
        /**
      
         * @returns If the index is 0, the result of the `unshift` method is returned.
         *          If the index is equal to the length of the linked list plus 1, the result of the `push` method is returned.
         *          If the index is less than 0 or greater than the length of the linked list, `false` is returned.
         *          Otherwise, no explicit output is mentioned in the code snippet.
         */
            let node = new ListNode(value);
            if (index === 0) return this.unshift(value);
            if (index === this.listLength) return this.push(value);
            if (index < 0 || index > this.listLength) return false;
            // get position before where you want to insert it
            let temp = this.get(index - 1);
            // point the new node to the next node of the main list from the index
            node.next = temp.next;
            // point temp to the new node
            temp.next = node;
            this.listLength++
            return true
        
    }
    //get from the list from an index
    get(index: number) {
        let temp = this.head
        if (index < 0 || index > this.listLength) {
            return new ListNode(null)
        }
        else {
            let counter: number = 0;
            while (counter <index) {
                    temp = temp.next
                    counter++
                }
               
        }
        return temp
    }

    reverse() {
        // swap the head with the tail
        let temp = this.head
        this.head= this.tail
        this.tail = temp
        // create a reverse next variable that will be the temp.next
        let reverseNext: ListNode = temp.next
        // set a variable pre to hold each previous value
        let pre: ListNode = new ListNode(null)
        //counter
        let counter: number = 0
        //iterate the entire lise
        while (counter < this.listLength) {
            //reverse next = the next of the temp
            reverseNext = temp.next
            // set the next node of the temp to the previous node
            temp.next = pre
            // set the previous node to temp
            pre = temp 
            // there would be gap so use this to set close the gap between temp and the reverse next
            temp = reverseNext
            //nincrrement counter
            counter++
        }
        // return the head of the linked list
        return this.head
    }
    //set the value of a node from its index and value
    set(index: number, value: any) {
        if(index>this.listLength) return false
        let node: ListNode = this.get(index);
        node.value = value
        return true;

    }
    pop() {
        let emptyNode = new ListNode(null)
        let temp = this.head
        let pre = temp
        if (this.checkEdgeCase(true)) {
            while (temp.next) {
                pre = temp
                temp = temp.next
                console.log(temp)
            }
            console.log(temp)
            this.tail = pre;
            this.tail.next = undefined
        }
        this.listLength--
        if (this.listLength == 0) {
            this.head = emptyNode
            this.tail = emptyNode
        }   
        return temp
    }
    checkEdgeCase(ispop?:boolean): boolean{
        let returnStatus: boolean = false;
        if (!this.head || this.head.value ==null) {

            returnStatus = false;
        }
        if (ispop)
        {
            this.listLength == 1 ? returnStatus = false : returnStatus = true;   
        }
        return returnStatus;
    }
    
}
let list = new LinkedList(12);
list.push(145)
list.push(134)
list.pop()



console.log('---------')
console.log(list)

