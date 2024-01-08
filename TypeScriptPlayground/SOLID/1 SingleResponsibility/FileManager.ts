const fs = require('fs')
export class FileManager{
    saveToFile(item, filename) {
        fs.writeFileSync(filename,item)
    }
}