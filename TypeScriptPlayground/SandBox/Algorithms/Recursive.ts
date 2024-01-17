import { number } from "ts-pattern/dist/patterns";

class Recursive {
  factorial(value: number): number {
    if (value === 1) {
      return value;
    }
    return value * this.factorial(value - 1);
  }
  fibonacci(value: number): number {
    if (value <= 1) {
      return value;
    }
    return this.fibonacci(value - 1) + this.fibonacci(value - 2);
  }
}
let recursive = new Recursive();
for (let i = 0; i < 4; i++) {
  console.log(`Fibonacci(${i}):`, recursive.fibonacci(i));
}
console.log(recursive.factorial(5));
