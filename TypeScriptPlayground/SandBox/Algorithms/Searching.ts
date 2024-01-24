import { Sorts } from "./Sorts";

class Search {
  linearSearch(items: any[], target: any): any {
    for (let i = 0; i < items.length - 1; i++) {
      if (target == items[i]) {
        return i;
      }
    }
    return -1;
  }
  binarySearch(items: any[], target: any): boolean {
    if (items.length === 1) {
      console.log(items);
      return items[0] === target;
    }

    const middleIndex = Math.floor(items.length - 1 / 2);
    let slicedItems =
      items[middleIndex] > target
        ? items.slice(0, middleIndex)
        : items.slice(middleIndex);
    console.log(slicedItems);
    return this.binarySearch(slicedItems, target);
  }
}

//==================TESTS=====================
let numbers = [99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0];
let search = new Search();
let sort = new Sorts();
numbers = sort.mergeSort(numbers);

console.log("Item is found at index of " + search.binarySearch(numbers, 5));
