

export class ProductFilter{
    // this is breaking the open closed principle
    // creates states space explotion
    filterByColor(myProduct:any[], color:string) {
        let filter = myProduct.filter(product => product.color === color)
        return filter;
    }
}

// use the specificiation pattern for any kind of filter so this code is not touched
export class BetterFilter {
    filter(items: any[], spec:any) {
        return items.filter(item=> spec.isSatisfied(item))
    }
   
}

