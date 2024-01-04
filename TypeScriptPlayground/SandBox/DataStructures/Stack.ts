import { StackNode } from "./StackNode"

class Stack {
    top: StackNode
    bottom: StackNode
    height: number
    constructor(value: any) {
        this.top = new StackNode(value)
        this.bottom = this.top
        this.height = 1
    }
    push(value: any) {
        let newNode = new StackNode(value)
        if (this.height === 0) {
            this.top = newNode;
        }
        else {
            newNode.next = this.top
            this.top = newNode; 
        }
        this.height++
        return this
    }
    pop() {
        if (this.height === 0) {
            return undefined;
        }
        let temp = this.top;
        this.top = this.top.next
        temp.next = null;
        this.height--;
        return temp
        
        
    }
}
let mystack = new Stack(12)
mystack.push(18)
mystack.push(18)
console.log("pre \n"+JSON.stringify(mystack))
mystack.pop()
console.log("post \n"+JSON.stringify(mystack))
