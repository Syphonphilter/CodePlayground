import { number } from "ts-pattern/dist/patterns";

class Recursive {
  factorial(value: number): number {
    if (value === 1) {
      return value;
    }
    return value * this.factorial(value - 1);
  }
  factorialRecursive(value: number) {
    // if value is one then no need to do the factorial
    // target  = 1*2*3*4*5
    if (value === 1) {
      return value;
    }
    let factorialValue = 1;
    for (let i = 2; i <= value + 1; i++) {
      factorialValue = factorialValue * (i - 1);
    }
    return factorialValue;
  }
  factorialRecursivev2(value: number) {
    if (value === 1) {
      return value;
    }
    let factorialValue = value;
    for (let i = value; i > 0; i--) {
      if (i != 1) {
        factorialValue = factorialValue * (i - 1);
      }
    }
    return factorialValue;
  }
  fibonacci(value: number): number {
    if (value <= 1) {
      return value;
    }
    return this.fibonacci(value - 1) + this.fibonacci(value - 2);
  }
  fibonacciIterative(iterations: number) {
    let fibs: number[] = [0, 1];
    if (iterations <= 2) {
      return fibs;
    }
    for (let i = 2; i <= iterations; i++) {
      fibs.push(fibs[i - 1] + fibs[i - 2]);
    }
    return fibs.join(",");
  }
}
let recursive = new Recursive();
for (let i = 0; i < 4; i++) {
  console.log(`Fibonacci(${i}):`, recursive.fibonacci(i));
}
console.log(recursive.factorial(5));
console.log(recursive.factorialRecursive(5));
console.log(recursive.factorialRecursivev2(5));
console.log(recursive.fibonacciIterative(9));
