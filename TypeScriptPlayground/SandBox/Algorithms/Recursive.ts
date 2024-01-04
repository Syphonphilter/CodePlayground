import { number } from "ts-pattern/dist/patterns"

class Recursive{

    factorial(value: number):any {
      
        if (value === 1) {
            return 1
        }
       return  value * this.factorial(value-1)
    }
    fibbonaci(count: number): any {
        if (count <= 1) {
            return count
        }
        else {
            return this.fibbonaci(count-1)+ this.fibbonaci(count-2)
        }
    }
}
let recursive = new Recursive()
for (let i = 0; i < 1; i++) {
    console.log(`Fibonacci(${i}):`, recursive.fibbonaci(i));
}
console.log(recursive.factorial(5))