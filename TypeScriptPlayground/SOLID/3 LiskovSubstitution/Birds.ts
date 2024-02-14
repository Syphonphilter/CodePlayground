//* Rather than making one bird class make seprate bird classes for each type of bird
//* Follows the Liskovs substitution principle
class FlyingBird{
    fly() {
        console.log('I can fly')
    }
}
class SwimmingBird{
    swim() {
        console.log('I can Swim')
    }
}

class Penguin extends SwimmingBird{

}
class Duck extends FlyingBird{
    quack() {
        console.log('I quakced')
    }
}

function makeFlyingBirdFly(bird: Duck){
bird.fly()
}
function makeSwimmingBirdSwim(bird: Penguin){
bird.swim()
}
const duck = new Duck
const penguin  = new Penguin
makeFlyingBirdFly(duck)
makeSwimmingBirdSwim(penguin)


//! WHAT IF I WANT TO MAKE A SWIMMING FLYING BIRD SWIM AND FLY
//* MAKE USE OF COMPOSITION TO DESCRIBE WHAT AN OBJECT CAN DO WHILE INHERITANCE SHOULD DESCRIBE WHAT AN OBJECT IS
function Swimmer(name: string ) {
    const birdName = {name:name}
    return {
        swimo:()=> console.log(`${birdName.name} can swim`)
    }
}
function Flyer(name: string) {
    //* object destucturing
    const birdName = {name:name}
    return {
        fly:()=> console.log(`${birdName.name} can fly`)
    }
}
function swimmerAndFlyer(name: any) {
    //* object desctucturing
    const birdName = {name:name}
    return {
        fly:()=> console.log(`${birdName.name} can fly`),
        swim:()=> console.log(`${birdName.name} can swim`)
    }
}
function killerAndStronger(name: any) {
    //* object desctucturing
    const birdName = {name:name}
    return {
        kill:()=> console.log(`${birdName.name} can kill`),
        storng:()=> console.log(`${birdName.name} is strong`)
    }
}


//* Using higher order functions using desctructuring
function swimmingFlyingBirdCreator(name: string) {
    const bird = { name: name }
    return {
        ...bird,
        //* rather than doingt his
        ...Swimmer(bird.name),
        ...Flyer(bird.name),
        //* also can so this 
        ...swimmerAndFlyer(bird.name),
        ...killerAndStronger(bird.name)

    }
    
}

///
const obj = Flyer( 'Duck' )
const objx = Swimmer('Penguin')
obj.fly()
objx.swimo()


// to make a bird swim and fly
const objct = swimmingFlyingBirdCreator('Duck')
const objct1 = swimmingFlyingBirdCreator('Penguin')
const objct2 = swimmingFlyingBirdCreator('Vulture')
objct.swim()
objct.fly()
objct1.swim()
objct2.kill()
objct2.storng()
objct2.fly()
objct2.swimo();
