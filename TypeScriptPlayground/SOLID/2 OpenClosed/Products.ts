import { Color, Size } from "./Enums"
import { BetterFilter, ProductFilter } from "./Fillters"
import { AllSpeicifcations, ColorSpecification, SchoolSpecification, SizeSpecification } from "./Specifications"

class Product {
    color
    size
    name
    constructor(name,color, size) {
        this.name = name
        this.color = color
        this.size = size
    }
    
}
let newAppleProduct = new Product('Apple',Color.green,Size.medium)
let newHouseProduct = new Product('House', Color.green, Size.large)

let productFilter = new ProductFilter()
let allProducts: any[] = []
allProducts.push(newAppleProduct, newHouseProduct)
console.log(allProducts)
console.log("Green Produts in the bad approach that creates state space explotion\n")
for (let p of productFilter.filterByColor(allProducts, Color.green)) {
    console.log(`*${p.name} is green`)
}

class School{
    classRoom:string
    studentCount:number
    instructor:string
    constructor(classroom, count, instructor) {
        this.classRoom = classroom
        this.studentCount = count
        this.instructor = instructor
    }
}
class SchoolFilter{
    filterBycount(school:any[], count:number) {
        return school.filter(school=> school.studentCount> count)
    }
}

let schoolA = new School('C#',234,'Bala')
let schoolB = new School('JavaScript',900,'Bala')
let schoolC = new School('Pyhton',100,'James')
let schoolD = new School('Rust', 50, 'Paul')
let allSchools: any[] = []
allSchools.push(schoolA, schoolB, schoolC, schoolD)

let sf = new SchoolFilter()
console.log('Bad approach that creates State Space Explotion\n')
for (let f of sf.filterBycount(allSchools, 100)) {
     console.log(`${f.classRoom} has over 100 Students`)
}
console.log(' ')
console.log('Good approach for proucts that solved State Space Explotion using specification principle\n')
let betterFilter = new BetterFilter()
for (let p of betterFilter.filter(allProducts, new ColorSpecification(Color.green))) {
    console.log(`${p.name} is a green product`)
}
console.log(' ')

console.log('Good approach for schools that solved State Space Explotion using specification principle\n')
let betterSchoolFilter = new BetterFilter()
for (let p of betterSchoolFilter.filter(allSchools, new SchoolSpecification(100))) {
    console.log(`${p.classRoom} has over 100 students`)
}
console.log(' ')
console.log('Large and green producs')
let allspecs = new AllSpeicifcations(new ColorSpecification(Color.green), new SizeSpecification(Size.large))
for (let p of betterFilter.filter(allProducts, allspecs)) {
    console.log(`${p.name} is green and large`)
}
