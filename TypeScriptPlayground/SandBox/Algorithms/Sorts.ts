import { P } from "ts-pattern";
import { array } from "ts-pattern/dist/patterns";

export class Sorts {
  // BUBBLE SORT O(N^2)
  // Iteratively  steps through a list of elements, compares adjacent elements and swaps them if they are in the wrong order.
  bubbleSort(items: number[]) {
    // iterate throught the items in reverse
    for (let i = items.length - 1; i > 0; i--) {
      // iterate through the items up to position i
      for (let j = 0; j < i; j++) {
        // check if the value ahead of j is greater then the current value of j
        if (items[j] > items[j + 1]) {
          // swap them
          let temp = items[j];
          items[j] = items[j + 1];
          items[j + 1] = temp;
        }
      }
    }
    return items;
  }
  //Repetedly finds the smallest index in an unsorted array and pushes the element to beginning of the sorted portion of the array item
  selectionSort(items: number[]) {
    // set the smallest item to 0
    let smallestIndex = 0;
    // selection sort is O(N^2)
    // start with the two pointers i and j
    for (let i = 0; i < items.length; i++) {
      // set the smallest index to i for each iteration of i
      smallestIndex = i;
      for (let j = i + 1; j < items.length; j++) {
        //iteratively compare j with i to find the smallest
        if (items[smallestIndex] > items[j]) {
          // if smallest is > than j then j is the smallest
          smallestIndex = j;
        }
      }

      // swap value of the smallest  with i
      let temp = items[i];
      items[i] = items[smallestIndex];
      items[smallestIndex] = temp;
    }
    return items;
  }
  insertionSort(items: number[]) {
    let temp = 0;
    for (let i = 1; i < items.length; i++) {
      temp = items[i];
      for (var j = i - 1; items[j] > temp; j--) {
        items[j + 1] = items[j];
      }
      items[j + 1] = temp;
    }
    return items;
  }
  mergeFunction(arr1: number[], arr2: number[]) {
    let combined: number[] = [];
    let j = 0;
    let i = 0;
    while (i < arr1.length && j < arr2.length) {
      if (arr1[i] < arr2[j]) {
        combined.push(arr1[i]);
        i++;
      } else {
        combined.push(arr2[j]);
        j++;
      }
    }
    while (i < arr1.length) {
      combined.push(arr1[i]);
      i++;
    }
    while (j < arr2.length) {
      combined.push(arr2[j]);
      j++;
    }
    return combined;
  }
  mergeSort(items: number[]): number[] {
    if (items.length == 1) return items;
    let mid = Math.floor(items.length / 2);
    let left = items.slice(0, mid);
    let right = items.slice(mid);
    // console.log(left);
    // console.log(right);
    return this.mergeFunction(this.mergeSort(left), this.mergeSort(right));
  }
  quickSortPivotSwap(array: number[], firstIndex: number, secondIndex: number) {
    let temp = array[firstIndex];
    array[firstIndex] = array[secondIndex];
    array[secondIndex] = temp;
  }

  quickSortPivot(
    array: number[],
    pivotIndex: number = 0,
    myendIndex: number | undefined = array.length - 1
  ) {
    let mySwapIndex = pivotIndex;
    for (let i = pivotIndex + 1; i <= myendIndex; i++) {
      if (array[pivotIndex] > array[i]) {
        mySwapIndex++;
        this.quickSortPivotSwap(array, mySwapIndex, i);
      }
    }
    this.quickSortPivotSwap(array, pivotIndex, mySwapIndex);

    return mySwapIndex;
  }
  quickSort(
    array: number[],
    left: number = 0,
    right: number = array.length - 1
  ) {
    if (!array) return [];
    if (left < right) {
      let pivotIndex = this.quickSortPivot(array, left, right);
      console.log(pivotIndex);
      this.quickSort(array, left, pivotIndex - 1);
      this.quickSort(array, pivotIndex + 1, right);
    }
    return array;
  }
}

class PracticeSorts {
  bubbleSort(number: number[]) {
    for (let i = number.length - 1; i >= 0; i--) {
      for (let j = 0; j < i; j++) {
        if (number[j + 1] < number[j]) {
          let temp = number[j + 1];
          number[j + 1] = number[j];
          numbers[j] = temp;
        }
      }
    }
    return numbers;
  }

  selectionSort(items: number[]) {
    let smallestIndex = 0;
    for (let i = 0; i <= items.length - 1; i++) {
      smallestIndex = i;
      for (let j = i + 1; j <= items.length - 1; j++) {
        if (items[smallestIndex] > items[j]) {
          smallestIndex = j;
        }
      }
      let temp = items[i];
      items[i] = items[smallestIndex];
      items[smallestIndex] = temp;
    }
    return items;
  }
}
let sort = new Sorts();
let psort = new PracticeSorts();
const numbers = [99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0];
console.log(sort.selectionSort(numbers));
console.log(psort.selectionSort(numbers));
