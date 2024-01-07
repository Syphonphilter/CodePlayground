import { any, array } from "ts-pattern/dist/patterns";

const sampleArray: any[] = [
    42,
    'hello',
    true,
    { name: 'Alice', age: 30 },
    [5, 10, 15],
    null,
    'world',
    7,
    false,
    [20, 30, 40],
    { city: 'New York', country: 'USA' },
    undefined,
    3.14,
    { fruits: ['apple', 'banana', 'orange'] },
    // Adding more elements to reach 100 items
    'random string',
    99,
    { hobby: 'coding' },
    ['a', 'b', 'c'],
    false,
    0,
    null,
    { nested: { value: 123 } },
    'another string',
    true,
    [1, 2, 3],
    { color: 'blue' },
    5.55,
    undefined,
    { name: 'Bob', age: 25 },
    'more data',
    [11, 22, 33],
    // Adding more elements...
    // Continue adding elements until reaching 100
    // Feel free to mix different data types and structures
];
const sampleArray2: any[] = [
    {fruits:['apple','banana']}
]

//FILTERS


const getnNumericalitems = sampleArray.filter(c=> c>=3)
const getSubarrays = sampleArray.filter(c => {
    return Array.isArray(c)
    // 
}).map((c: any) => {
    c.map((x:any) => {
        //console.log(x)
    })
})
// Accessing the "fruits" property within nested objects in sampleArray
const fruits = sampleArray
    .filter(item => typeof item === 'object' && item !== null && item != undefined).
    map((c) =>
  c.fruits)// Filter to get only non-array objects
// Access the "fruits" property from each nested object


let a = [1, 2, 3, 4]

// MAP

const mapfruits = sampleArray.map(c =>
{
    if (typeof c === 'object' && c !==null)
        try {
            let result = c.fruits
            
            return result
        } catch (error){
            console.log();
            
        }
})
const filteredFruits = mapfruits.filter(fruit => fruit !== undefined);
//console.log(filteredFruits);

const firstFruit = filteredFruits.map(fruit => fruit[0])
// console.log(firstFruit)


/// SOME

const objects = sampleArray.some(items => typeof items === 'object')
// console.log(objects)


// SORT

const sortbyType = sampleArray.sort()
// sort in reverse = b-a
const sortNumbers = sampleArray.filter(c => typeof c === 'number').sort((a, b) => a - b)
// sort strings -1 is reverse
const sortStrings = sampleArray.filter(c => typeof c === 'string').sort((a, b) => {
    if (a < b)
        return 1
    return -1
})
// console.log(sortStrings)

/// REDUCE
// this gets an end to some thing eg sum of all numbers

const sumofItemsinArray = sampleArray.filter(c => Array.isArray(c)).reduce((accum, curr) => {
    if (curr.every((element: any) => typeof element === 'number')) {
        return accum+ curr.reduce((ac: any, cu: any) => {
            return ac + cu
        }, 0)
    }
    return accum
}, 0)

/// EVERY

const everyObject = sampleArray.every(element => {

    if (typeof element === 'object' && !Array.isArray(element)) {
        return element
    }
}
)
console.log(everyObject)