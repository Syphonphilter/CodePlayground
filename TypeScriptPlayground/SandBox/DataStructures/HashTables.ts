import { has } from "benchmark";
import { number } from "ts-pattern/dist/patterns";

class HashTable{
    dataMap: any
    //define the size of the array
    constructor(size:any) {
     this.dataMap = new Array(size)
        
    }
    _hash(key: string) {
        let hash = 0; 
        for (let i = 0; i < key.length; i++){
            hash = (hash+ key.charCodeAt(i)*11)%this.dataMap.length
        }
        return hash
    }
    set(key: any, value: any) {
        let index = this._hash(key)
        if (!this.dataMap[index]) {
            this.dataMap[index] =  []
        }
        this.dataMap[index].push([key, value])
        return this
    }
    get(key: any) {
        let index = this._hash(key)
        if (!this.dataMap[index]) return undefined
        for (let i = 0; i < this.dataMap.length; i++)
        {
            if (this.dataMap[index][i][0] === key) {
                return this.dataMap[index][i][1]
            }
            }
    }
    
    keys() {
        if (this.dataMap.length === 0) return null
        else {
            let keyArray: any[] = new Array(this.dataMap.length)
            console.log(this.dataMap.length)
            for (let i = 0; i < this.dataMap.length; i++){
             
                if (this.dataMap[i]) {
                    
                    for (let j = 0; j < this.dataMap[i].length; j++)
                    {
                        keyArray.push(this.dataMap[i][j][0])
                        }
                }
            }
            return keyArray
        }
    }
}
let hashTable = new HashTable(0)

console.log(hashTable.keys())
