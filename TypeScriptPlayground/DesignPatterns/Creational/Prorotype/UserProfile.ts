class Address {
  city: String = "";
  street: String = "";
  houseNo: String = "";
  constructor(street, houseNo, city) {
    this.street = street;
    this.houseNo = houseNo;
    this.city = city;
  }
  deepCopy() {
    return new Address(this.street, this.houseNo, this.city);
  }
}
class Person {
  name: string = "";
  //*create the address property of type address
  address: Address;
  constructor(name, address) {
    this.name = name;
    this.address = address;
  }
  toString() {
    let userAddress = Object.values(`${this.address}`);
    return Object.values(
      `User name is ${this.name} and address is ${userAddress}`
    );
  }
  deepCopy() {
    return new Person(this.name, this.address.deepCopy());
  }
}

//* Wrong copy approach because the two properties both point to the same location in memory
let bala = new Person("Bala", new Address("490", "15", "Fredericton"));
let dave = bala;
dave.name = "Dave";
console.log(dave);
console.log(bala);

//* proposed solution would be to create a deep copy and if there is an object in the object, deep copy that object
console.log("==========Deep Copy============");
let dave1 = bala.deepCopy();
dave1.name = "Dave1";
dave1.address.street = "449";
console.log(bala);
console.log(dave1);

// * Better solution, serialization
//* first Build a serializer
class Serializer {
  types;
  constructor(type) {
    this.types = type;
  }
  markRecursive(object) {
    let idx = this.types.findIndex((type) => {
      return type.name === object.constructor.name;
    });
    // if (index !== -1) {
    // }
  }
  clone(object) {}
}
