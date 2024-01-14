class Person
{
    streetAddress:any
    postCode: any
    city: string
    companyName:string
    position:string
    annualIncome:number
  constructor()
  {
    // address info
    this.streetAddress = this.postCode = this.city = '';

    // employment info
    this.companyName = this.position = '';
    this.annualIncome = 0;
  }

  toString()
  {
    return `Person lives at ${this.streetAddress}, ${this.city}, ${this.postCode}\n`
      + `and works at ${this.companyName} as a ${this.position} earning ${this.annualIncome}`;
  }
}

class PersonBuilder
{
    person:Person
  constructor(person)
  {
    this.person = person;
  }

  get lives()
  {
    return new PersonAddressBuilder(this.person);
  }

  get works()
  {
    return new PersonJobBuilder(this.person);
  }

  build()
  {
    return this.person;
  }
}

class PersonJobBuilder extends PersonBuilder
{
  constructor(person)
  {
    super(person);
  }

  at(companyName)
  {
    this.person.companyName = companyName;
    return this;
  }

  asA(position)
  {
    this.person.position = position;
    return this;
  }

  earning(annualIncome)
  {
    this.person.annualIncome = annualIncome;
    return this;
  }
}

class PersonAddressBuilder extends PersonBuilder
{
  constructor(person)
  {
    super(person);
  }

  at(streetAddress)
  {
    this.person.streetAddress = streetAddress;
    return this;
  }

  withPostcode(postcode)
  {
    this.person.postCode = postcode;
    return this;
  }

  in(city)
  {
    this.person.city = city;
    return this;
  }
}

let myPerson:Person = new Person()
let pb = new PersonBuilder(myPerson);
let AppPerson = pb
  .lives.at('123 London Road').in('London').withPostcode('SW12BC')
  .works.at('Fabrikam').asA('Engineer').earning(123000)
  .build();
console.log(AppPerson.toString());
