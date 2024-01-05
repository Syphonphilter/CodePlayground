import { P } from "ts-pattern";
import { array } from "ts-pattern/dist/patterns";

class Sorts{
    bubbleSort(items:number[]) {
        for (let i = items.length - 1; i > 0; i--){
            for (let j = 0; j < i; j++){
                if (items[j] > items[j + 1]) {
                    let temp = items[j]
                    items[j] = items[j + 1]
                    items[j+1] = temp
                }
            }
        }
        return items;
    }
    
    selectionSort(items: number[]) {
        let smallestIndex = 0;

        for (let i = 0; i < items.length; i++){
            smallestIndex = i;
            for (let j = i + 1; j < items.length; j++) {
                if (items[smallestIndex] > items[j]) {
                    smallestIndex = j;
                }
            }
            
            let temp = items[i]
            items[i] = items[smallestIndex]
            items[smallestIndex] = temp
        }
        return items;
    }
    insertionSort(items: number[]) {
        let temp = 0
        for (let i = 1; i < items.length; i++){ 
            temp = items[i]
            for (var j = i - 1; items[j]>temp; j--) {
                 items[j+1] = items[j]
            }
            items[j+1] = temp
            }
        return items
    } 
    mergeFunction(arr1: number[], arr2: number[]) {
        let combined: number[] = []
        let j = 0 
        let i = 0
        while (i<arr1.length &&j< arr2.length) {
            if (arr1[i] < arr2[j]) {
                combined.push(arr1[i])
                i++
            }
            else {
                combined.push(arr2[j])
                j++
            }
        }
        while (i < arr1.length) {
            combined.push(arr1[i])
            i++
        }
        while (j < arr2.length) {
            combined.push(arr2[j])
            j++
        }
        return combined
    }
    mergeSort(items: number[]):number[] {
        if (items.length == 1) return items
        let mid = Math.floor(items.length / 2)
        let left = items.slice(0,mid)
        let right = items.slice(mid)
        console.log(left)
        console.log(right)
        return this.mergeFunction(this.mergeSort(left),this.mergeSort(right)) 
    }
    quickSortPivotSwap(array:number[], firstIndex:number, secondIndex:number) {
        let temp = array[firstIndex]
        array[firstIndex] = array[secondIndex]
        array[secondIndex]= temp
    }

    quickSortPivot(array: number[], pivotIndex:number = 0, myendIndex:number|undefined = array.length-1) {
        let mySwapIndex = pivotIndex
        for (let i = pivotIndex + 1; i <=myendIndex; i++){
            if (array[pivotIndex] > array[i]) {
                mySwapIndex ++
               this.quickSortPivotSwap(array,mySwapIndex,i)
            }
        }
        this.quickSortPivotSwap(array, pivotIndex, mySwapIndex)
       
        return mySwapIndex;
    }
    quickSort(array: number[], left: number = 0, right: number = array.length - 1) {
        if(!array) return []
        if (left < right) {
            let pivotIndex = this.quickSortPivot(array, left, right)
            console.log(pivotIndex)
            this.quickSort(array, left, pivotIndex - 1)
            this.quickSort(array, pivotIndex + 1, right)
        }
      return array
    }
}
let sort = new Sorts()
console.log(sort.quickSort([]))
