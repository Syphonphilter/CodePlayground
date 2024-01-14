const readline = require("readline");
let rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});
abstract class HotDrink {
  prepare() {}
}
abstract class HotDrinkFactory {
  prepare(amount: number) {}
}
class Tea extends HotDrink {
  prepare(): void {
    console.log("I love drinking tea");
  }
}
class Coffee extends HotDrink {
  prepare(): void {
    console.log("I love drinking coffee");
  }
}
class Mocha extends HotDrink {
  prepare(): void {
    console.log(" I love drinking mocha");
  }
}

class MochaFactory extends HotDrinkFactory {
  prepare(amount: number) {
    console.log("i am drinking mocha");
    return new Mocha();
  }
}
class TeaFactory extends HotDrinkFactory {
  prepare(amount: number) {
    console.log(`I am preparing tea using an amount of ${amount}`);
    return new Tea();
  }
}
class CoffeeFactory extends HotDrinkFactory {
  prepare(amount: number) {
    console.log(`I am preparing coffee using an amount of ${amount} `);
    return new Coffee();
  }
}

class HotDrinkMachine {
  factories = {};
  constructor() {
    this.factories = {};
    for (let drink in availableDrinks) {
      //* since the drink is a key we want to instanciate the value of it from its type
      this.factories[drink] = new availableDrinks[drink]();
    }
  }

  interact(consumer) {
    rl.question("What drink do you want? eg tea 50", (answer) => {
      let userAnswer = answer.split(" ");
      let name = userAnswer[0];
      let number = parseInt(userAnswer[1]);
      let drink = this.factories[name].prepare(number);
      rl.close();
      consumer(drink);
    });
  }

  makeDrink(type: string) {
    switch (type) {
      case "tea":
        return new TeaFactory().prepare(200);
      case "coffee":
        return new CoffeeFactory().prepare(10);
      default:
        throw new Error("No hot drink");
    }
  }
}

let availableDrinks = Object.freeze({
  tea: TeaFactory,
  coffee: CoffeeFactory,
  mocha: MochaFactory,
});
let machine = new HotDrinkMachine();

//* This would break the open closed principle and would not be efficient
//* this is because it would mean i would need to change the make drink method.
rl.question("what drink do you want?", function (answer) {
  let drink = machine.makeDrink(answer);
  drink.prepare();
  rl.close();
});
//* thus i would rather use create an enum of available drinks, then check if the drink placed by the user is in the Enum
machine.interact(function (drink) {
  drink.prepare();
});
