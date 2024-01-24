import { Tree } from "../DataStructures/Tree";
import { TreeNode } from "../DataStructures/TreeNode";

class TreeTraversals extends Tree {
  BreathFirstSearch() {
    if (!this.root) return [];
    let currentNode = this.root;
    let queue: TreeNode[] = [];
    let result: number[] = [];
    queue.push(currentNode);

    while (queue.length) {
      currentNode = queue[0];
      console.log(queue);
      result.push(currentNode.value);
      queue.pop();
      if (currentNode.left) queue.push(currentNode.left);
      if (currentNode.right) queue.push(currentNode.right);
    }
    return result;
  }
  BreathFirstSearch2() {
    if (!this.root) return [];
    let currentNode: TreeNode | undefined = this.root;
    let queue: TreeNode[] = [];
    let result: number[] = [];
    queue.push(currentNode);

    while (queue.length) {
      console.log(queue);
      currentNode = queue.shift();
      result.push(currentNode?.value);
      if (currentNode?.left) queue.push(currentNode.left);
      if (currentNode?.right) queue.push(currentNode.right);
    }
    return result;
  }
  DFSPreOrder() {
    if (!this.root) return [];
    let mycurrentNode: TreeNode = this.root;
    let result: number[] = [];
    const traverse = (currentNode: TreeNode | null) => {
      result.push(currentNode?.value);
      if (currentNode?.left) traverse(currentNode.left);
      if (currentNode?.right) traverse(currentNode.right);
    };
    traverse(mycurrentNode);
    return result;
  }
  DFSPostOrder() {
    if (!this.root) return [];
    let mycurrentNode: TreeNode = this.root;
    let result: number[] = [];
    const traverse = (currentNode: TreeNode | null) => {
      console.log(currentNode?.value);
      if (currentNode?.left) traverse(currentNode.left);
      if (currentNode?.right) traverse(currentNode.right);
      result.push(currentNode?.value);
    };
    traverse(mycurrentNode);
    return result;
  }
  DFSInOrder() {
    if (!this.root) return [];
    let mycurrentNode: TreeNode = this.root;
    let result: number[] = [];
    const traverse = (currentNode: TreeNode | null) => {
      console.log(currentNode?.value);
      if (currentNode?.left) traverse(currentNode.left);
      result.push(currentNode?.value);
      if (currentNode?.right) traverse(currentNode.right);
    };
    traverse(mycurrentNode);
    return result;
  }
}
class TreeTraversals2 extends Tree {
  BFS() {
    if (!this.root) return [];
    let currentNode = this.root;
    let queue = [];
    let result = [];

    queue.push(currentNode.value);
    while (queue.length) {
      currentNode = queue[0];
      result.push(currentNode.value);
      queue.pop();
      if (currentNode.left) queue.push(currentNode.left);
      if (currentNode.right) queue.push(currentNode.right);
    }
    return result;
  }
}
let traverse = new TreeTraversals();

traverse.insert(47);
traverse.insert(21);
traverse.insert(76);
traverse.insert(18);
traverse.insert(27);
traverse.insert(52);
traverse.insert(82);
console.log(traverse.BreathFirstSearch());
