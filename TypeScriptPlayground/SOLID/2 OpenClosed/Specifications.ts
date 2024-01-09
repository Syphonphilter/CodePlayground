abstract class Specifications{
    constructor() {
        if (this.constructor.name === 'Specifications')
            throw new Error('Specifiction is an abstract class use this so as not to violate Open Closed Principle')
    }
    abstract isSatisfied(item:any[]):Boolean
}
class ColorSpecification extends Specifications{
    color:string
    constructor(color) {
        super()
        this.color = color
    }
    isSatisfied(item:any):Boolean {
        return this.color === item.color
    }
}

class SchoolSpecification extends Specifications{
    count:string
    constructor(count) {
        super()
        this.count = count
    }
    isSatisfied(school):Boolean {
        return school.studentCount> this.count
    }
}
class SizeSpecification extends Specifications{
    size:string
    constructor(size) {
        super()
        this.size = size
    }
    isSatisfied(item):Boolean {
        return this.size === item.size
    }
}

//* A combination of specifications

class AllSpeicifcations extends Specifications{
    specs:any[]
    constructor(...specs) {
        super()
        this.specs = specs
    }
    isSatisfied(item) {
        return this.specs.every(specs=> specs.isSatisfied(item))
    }
}

export{ColorSpecification,SchoolSpecification, AllSpeicifcations, SizeSpecification}