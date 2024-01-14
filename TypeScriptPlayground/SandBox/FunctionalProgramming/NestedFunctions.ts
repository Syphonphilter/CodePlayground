function outer(a: number) {
  return function (b: number) {
    return a * b;
  };
}

const multiple = outer(3);
console.log([2, 3, 4].map(multiple));

//* When a collection passes this in the map function the items in the collection would first be returned then the parent item
//* utilizing the call stack
function Surname(lastname: string) {
  return function (firstName: string) {
    return `${firstName} has a last name of ${lastname} which means she is part of the ${lastname} family`;
  };
}

const familyName = Surname("Bala");
console.log(["Jummai", "Kaltume", "Abdulkadir"].map(familyName));
