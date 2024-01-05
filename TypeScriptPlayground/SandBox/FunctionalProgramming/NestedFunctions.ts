function outer(a: number) {
   return function (b:number) {
        return a * b;
    }   
}

const multiple = outer(3)
console.log(
    [2,3,4].map(multiple)
)