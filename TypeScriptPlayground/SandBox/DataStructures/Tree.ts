import { TreeNode } from "./TreeNode";

class Tree{
    root:TreeNode|null
    constructor() {
        this.root = null

    }
    insert(value: any) {
        let newNode = new TreeNode(value)
        if (this.root === null) {
            this.root = newNode
            return this
        }
        else {
            let temp = this.root
            while (temp!= null) {
                if(temp.value === value) return undefined
                if (newNode.value < temp.value) {
                    if (temp.left === null) {
                        temp.left = newNode
                        return this
                    }
                    temp = temp.left
                }
                else {
                    if (temp.right === null) {
                        temp.right = newNode
                        return this
                    }
                    temp= temp.right
                }
            }
            
            return temp;
        }
    }

    contains(value: any):boolean {
        if (this.root === null) return false
        let temp = this.root
        while (temp != null) {
            if (value < temp.value)
            {
                temp = temp.left
            }
            else if (value > temp.value) {
                temp = temp.right
            }
            else {
                return true
            }
        }
        return false;
    }

    minimumValue(currentNode: TreeNode):any {
        while (currentNode.left) {
            currentNode = currentNode.left
        }
        return currentNode
    }
}

const tree = new Tree()
tree.root = new TreeNode(7)
tree.insert(5)
tree.insert(9)

console.log(tree.minimumValue(tree.root))
