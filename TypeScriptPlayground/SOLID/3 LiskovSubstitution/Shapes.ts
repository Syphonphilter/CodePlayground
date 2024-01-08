
class Rectangle 
{
    width: number;
    height: number;
    
    constructor(width:number, height:number) {
        this.width = width
        this.height  = height
    }
    setWidth(width) {
        this.width = width
    }
    setHeight(height) {
        this.height = height
    }
    getHeight() {
        return this.height
    }
    getWidth() {
        return this.width
    }
    calculateArea()
    {
        return this.width* this.height
    }
}



class Square extends Rectangle {
    setWidth(width) {
        this.width = width
        this.height = width
    }
    setHeight(height) {
        this.height = height
        this.width = height
    }
}
const rect = new Rectangle(10, 5)

const sqre = new Square(6,6)

//! This breaks liskovs Subsitution principle
const increaseHeight=(rect,value)=>{
    rect.setHeight(rect.getHeight() + value)
    return rect.getHeight();
}
console.log(`New rectangle height is ${increaseHeight(rect, 20)}`)
//* this should only increase the height since a square is a rectangle
console.log(`New square height is ${increaseHeight(sqre,20)}`)
console.log(`New Rect Area is ${rect.calculateArea()}`)
console.log(`New Square Area is ${sqre.calculateArea()}`)