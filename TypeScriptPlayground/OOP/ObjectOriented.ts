import { Type } from "typescript";

enum IntrestRates {
  currentRate = 10,
}

//* 1. Class a blueprint
abstract class BankAccount {
  //* 2. encapsulated property
  private static accountNumber: number;
  static accountBalance: any;

  //* 3. constructor is called when ever the instance of the class is being created

  constructor(accountNumber: number, accountBalance) {
    BankAccount.accountNumber = accountNumber;
    BankAccount.accountBalance = accountBalance;
  }

  //* 4. abstract class member
  abstract updateAmount(amount: number);
  //* public static class member , using static because it is a utility function
  static printStatement() {
    return `Your Account: ${this.accountNumber} has a balance of $ ${this.accountBalance}`;
  }

  printStatementofInstances() {
    return `Your Non Static Account: ${BankAccount.accountNumber} has a balance of $ ${BankAccount.accountBalance}`;
  }
  printStatementWithIntrest() {
    return `Your Account: ${BankAccount.accountNumber} has a balance of $ ${BankAccount.accountBalance}`;
  }
}

//* 5. Inhertance
class SavingsAccount extends BankAccount {
  constructor(accountNumber: number, accountBalance: any) {
    super(accountNumber, accountBalance);
  }
  updateAmount(amount: number) {
    SavingsAccount.accountBalance += amount;
    return SavingsAccount.accountBalance;
  }

  //* 7. Polymorphism -overloading
  addIntrest(intrestRate: number);
  addIntrest(intrestRate: number, taxCuts: number);
  addIntrest(interestRate: number, taxCuts?: number) {
    let finalBalance =
      SavingsAccount.accountBalance -
      SavingsAccount.accountBalance * (interestRate / 100);

    SavingsAccount.accountBalance = taxCuts
      ? finalBalance + taxCuts
      : finalBalance;
    return this;
  }

  //* 7 Polymorphism-overload
  printStatementWithIntrest(): string {
    return `Your account has been updated with intrest of ${IntrestRates.currentRate}`;
  }
}
class CurrentAccount extends BankAccount {
  constructor(accountNumber: number, accountBalance: any) {
    super(accountNumber, accountBalance);
  }
  updateAmount(amount: number) {
    SavingsAccount.accountBalance += amount;
    return SavingsAccount.accountBalance;
  }

  //* 7. Polymorphism -overloading
  accountMaintenance(intrestRate: number, maintenanceFee: number);
  accountMaintenance(
    intrestRate: number,
    maintenanceFee: number,
    taxCuts: number
  );
  accountMaintenance(
    interestRate: number,
    maintenanceFee: number,
    taxCuts?: number
  ) {
    let finalBalance =
      SavingsAccount.accountBalance -
      SavingsAccount.accountBalance * (interestRate / 100) +
      maintenanceFee;
    SavingsAccount.accountBalance = taxCuts
      ? finalBalance + taxCuts
      : finalBalance;
    return this;
  }

  //* 7 Polymorphism-overload
  printStatementWithIntrest(): string {
    return `Your account has been updated with intrest of ${IntrestRates.currentRate}`;
  }
}

//* 6. Object: an instance of the class and since i have made he printStatement static it means that only one instance of the
//* BankAccount is refrenced and does not create mutiple instances of the BankAccount Super class

let mySavingsAccount = new SavingsAccount(1002003, 100);
let mySavingsAccount2 = new SavingsAccount(10020044, 400);
mySavingsAccount.updateAmount(200);
mySavingsAccount.addIntrest(IntrestRates.currentRate);
mySavingsAccount2.updateAmount(100);
console.log(SavingsAccount.printStatement());
console.log(mySavingsAccount.printStatementWithIntrest());
// console.log(mySavingsAccount2.printStatementofInstances());

class AppUser {
  //* 8 Association: when classes are associated by relationships
  userAccount: SavingsAccount | CurrentAccount;
  userName: string;
  constructor(userName, userAccount) {
    this.userName = userName;
    this, (userAccount = userAccount);
  }
  //* 9. Composition
  ChargeAccount() {
    this.userAccount.updateAmount(200);
  }
}
