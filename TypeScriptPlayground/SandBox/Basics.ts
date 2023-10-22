import moment from "moment"
//* Type Alias
type stringOrNum = string|number;
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
 const isValid=(id:stringOrNum):boolean=>{
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

//* interfaces
interface school{
    name:string,
    address:string,
    performance(a:number):number,

}
let chs:school={
    name:'cannan',
    address:'shaka',
    performance:(a:number)=>{
        a=a**a
        return a
    }
}
const saySchool=(school:school)=>{
console.log(school.name);
}
saySchool(chs);
// YOU CAN ALSO USE INTERFACES WITH CLASSES and when the class object is called,
// just let the type be the interface eg if class a implements interface b
// then you can say let a:b and c = new a(a params)
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
// * function Signatures
let sum :(a:number, b:number, action:string)=> number;
sum=(firstNum:number,secondNum:number, functionAction:string)=>{

    return firstNum+secondNum
}
//////////* OOP
//* CLASSES
class person{

    // you can comment this and pass the propeties directly to the constructors but ensure you add the access modifier
    //like so 
    // constructor(public name:string, public age:number, public gender:boolean){
    // }
    name:string;
    private age:number;
    gender:boolean;

    constructor(a:string,b:number,c:boolean){
        this.name = a;
        this.age= b;
        this.gender= c
    }

}
let user = new person( 'baa',23,false);
let user2 = new person( 'baa',23,false);
let appPeople :person[]=[]
appPeople.push(user)
user  = 23;
//* Pattern Matching
function someFunction (data:number)=>{
    return data when{
        1 -> 'One',
        2 -> 'Two',
        _-> 'None'
    };   
}
