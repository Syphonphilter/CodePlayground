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
  