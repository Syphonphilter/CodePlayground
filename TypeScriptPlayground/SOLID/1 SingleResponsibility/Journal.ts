import { FileManager } from "./FileManager"

class Journal{

    count: number = 0 
    entries:{}
    constructor() {
       this.entries = {}
    }
    addEntry(text) {
        let entryNumber = ++this.count
        let entry = `${entryNumber}: ${text}`
        this.entries[entryNumber] = entry
        return entryNumber
    }
    deleteEntries(entryNumber) {
        delete this.entries[entryNumber]
    }
    toString() {
        // join object by sepereating them with a new line 

        return Object.values(this.entries).join('\n')
    }
}

let myJournal = new Journal()
myJournal.addEntry('omo i have to get this shit down')
myJournal.addEntry('and master design priciples')

const file = new FileManager
const filepath = '/Users/syphonphilter/Projects/Playground/TypeScriptPlayground/SOLID/1 SingleResponsibility/'
file.saveToFile(myJournal.toString(),filepath+'journal.txt')


console.log(myJournal.toString())



