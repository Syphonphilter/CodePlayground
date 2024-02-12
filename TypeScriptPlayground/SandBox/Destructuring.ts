let a = [1, 2, 3, 4, 5]
let c = [...a, 6, 7]

console.log(c)

const person = {
    myname: 'Bala',
    age: 20,
    address: {
        street: 'regent',
        number:'490'
    }
}

const { myname, age } = person

console.log(myname)

const alphabet = ['A','B','C','D']
const numbers = [1,2,3,4]

const [aa,b] = alphabet

const sumandMultiply=(a:number,b:number)=>{
    return [a+b,a*b]
}

const [sum, mul] = sumandMultiply(2,5)
console.log(sum, 'is the sum from destructured function')
console.log(mul, 'is the multiplication from destructured function')
console.log(b, 'Des')
// Function accepting an object parameter and using destructuring
function printPersonInfo({ name, age }: {name:any,age:number}) {
    console.log(`${name} is ${age} years old.`);
}
const personInfo = {
    name: 'Alice',
    age: 25
  };


  
  // Passing an object to the function
  printPersonInfo(personInfo); // Output: Alice is 25 years old.
  