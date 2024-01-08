import { Copy, Print, Scan } from "./Interfaces";


class NewPrinter implements Scan, Print, Copy
{
    scan() {
        console.log('I can Scan new')
    };
    print() {
        console.log('I can print new')
    };
    copy() {
        console.log('I can copy new')
    };
}
class OldPrinter implements Print{
    print() {
        console.log('I can print old')
    }
}

const _2024printer = new NewPrinter()
_2024printer.copy()
_2024printer.scan()
_2024printer.print()

const _2000printer = new OldPrinter()
_2000printer.print()