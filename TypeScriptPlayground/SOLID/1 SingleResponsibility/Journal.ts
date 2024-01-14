import { FileManager } from "./FileManager";

class Journal {
  //* instance
  static instance: Journal;
  count: number = 0;
  entries: {};

  private constructor() {
    this.entries = {};
  }
  addEntry(text) {
    let entryNumber = ++this.count;
    let entry = `${entryNumber}: ${text}`;
    this.entries[entryNumber] = entry;
    return entryNumber;
  }
  deleteEntries(entryNumber) {
    delete this.entries[entryNumber];
  }
  toString() {
    // join object by sepereating them with a new line

    return Object.values(this.entries).join("\n");
  }
  //* Singleton design pattern .
  //* to use this make constructor private and make it instanciated only once
  static getInstance(): Journal {
    if (!Journal.instance) {
      Journal.instance = new Journal();
    }
    return Journal.instance;
  }
}

let myJournal = Journal.getInstance();
// let anotherJournal = Journal.getInstance()
// anotherJournal.addEntry('Should not work because of singleton')
myJournal.addEntry("omo i have to get this shit down");
myJournal.addEntry("and master design priciples");

const file = new FileManager();
const filepath =
  "/Users/syphonphilter/Projects/Playground/TypeScriptPlayground/SOLID/1 SingleResponsibility/";
file.saveToFile(myJournal.toString(), filepath + "journal.txt");

console.log(myJournal.toString());
