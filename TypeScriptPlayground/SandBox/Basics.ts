import moment from "moment"

//* Function Definition
const getAreaOfCircle =(raduis:number)=>{
    return Math.PI* raduis**2
}
// console.log(getAreaOfCircle(20))
const swapper_in_place=(a:number,b:number):[number,number]=>{
    a = a+b
    b = a-b
    a = a-b
return [a,b]
}
//
console.log(swapper_in_place(3,5))
let greet:Function;
greet =(name:string)=>{
    // console.log(name)
}
const _math=(a:number,b:number,c?:number):void=>{
        // console.log(a+b)
}
 const isValid=(id:string|number):boolean=>{
    return false;
 }
//* Data Structures
//* Arrays
let name = ['bala','musa','musty']
let any = ['bala','musa','musty',1,1.0]
//* push, pop,length,join,indexof
// console.log(name.indexOf('bala'))
//* Lists

//* Dictionaries
const dictionary:{[key:number]:any}= {}
dictionary[1] = "Bala"
dictionary[2] = "Musa"
for(var key in dictionary){
    if(dictionary.hasOwnProperty(key)){
        // console.log(key,dictionary[key])
    }
}
//* HashMap
const map = new Map<number,any>()
for(var i = 0; i<=3;i++){
    map.set(i,i+3)
}
for(const [key,value] of map){
    // console.log(key,value)
}
const x = map.get(3)
// console.log(x)
//* Objects
let Person =
{
    name:'bala',
    age:26
}
Person.age = 23
let School :object
School ={
 Name : "Cannan High",
 StudentNo:20
}
let States :{
    name:string,
    capital:string,
    isFederalCapital:boolean
}
//* explicit types 
let people:string[] = []
people.push('bala')
//* union types 
let groups:(string|number)[] = [];
groups.push(3)
let ids : string|number 
ids = 3;
const de ={a:1}
de.a = 1
