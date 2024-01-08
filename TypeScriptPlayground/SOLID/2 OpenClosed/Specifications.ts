class ColorSpecification{
    color:string
    constructor(color) {
        this.color = color
    }
    isSatisfied(item:any):Boolean {
        return this.color === item.color
    }
}

class SchoolSpecification{
    count:string
    constructor(count) {
        this.count = count
    }
    isSatisfied(school):Boolean {
        return school.studentCount> this.count
    }
}
class SizeSpecification{
    size:string
    constructor(size) {
        this.size = size
    }
    isSatisfied(item):Boolean {
        return this.size === item.size
    }
}

// A combination of specifications
class AllSpeicifcations{
    specs:any[]
    constructor(...specs) {
        this.specs = specs
    }
    isSatisfied(item) {
        return this.specs.every(specs=> specs.isSatisfied(item))
    }
}

export{ColorSpecification,SchoolSpecification, AllSpeicifcations, SizeSpecification}