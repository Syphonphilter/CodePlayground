import { TreeNode } from "./TreeNode";

export class Tree {
  root: TreeNode | null;
  constructor() {
    this.root = null;
  }
  insert(value: any) {
    let newNode = new TreeNode(value);
    if (this.root === null) {
      this.root = newNode;
      return this;
    } else {
      let temp = this.root;
      while (temp != null) {
        if (temp.value === value) return undefined;
        if (newNode.value < temp.value) {
          if (temp.left === null) {
            temp.left = newNode;
            return this;
          }
          temp = temp.left;
        } else {
          if (temp.right === null) {
            temp.right = newNode;
            return this;
          }
          temp = temp.right;
        }
      }

      return temp;
    }
  }

  contains(value: any): boolean {
    if (this.root === null) return false;
    let temp = this.root;
    while (temp != null) {
      if (value < temp.value) {
        temp = temp.left;
      } else if (value > temp.value) {
        temp = temp.right;
      } else {
        return true;
      }
    }
    return false;
  }

  minimumValue(currentNode: TreeNode): any {
    while (currentNode.left) {
      currentNode = currentNode.left;
    }
    return currentNode;
  }
}

const tree = new Tree();
tree.root = new TreeNode(7);
tree.insert(5);
tree.insert(9);

console.log(tree.minimumValue(tree.root));
/**
 * Finds the maximum product of any two adjacent numbers in the input array.
 * @param inputArray - An array of numbers.
 * @returns The maximum product of any two adjacent numbers in the input array.
 */
/**
 * Calculates the maximum product of any two adjacent numbers in an input array.
 * @param inputArray - An array of numbers.
 * @returns The maximum product of any two adjacent numbers in the input array.
 */

/**
 * Calculates the result based on the input number `n` using a loop and a mathematical formula.
 * @param n - The input number for the calculation.
 * @returns The calculated result based on the input number `n`.
 */
function solution(n: number): number {
  if (n === 1) {
    return 1;
  } else {
    let result = 1;
    for (let i = 1; i < n; i++) {
      const factor = 4 * n - 1;
      result += factor;
    }
    return result;
  }
}
