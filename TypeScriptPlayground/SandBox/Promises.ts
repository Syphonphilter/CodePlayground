const firstPromise = new Promise((resolve, reject)=>{
 setTimeout(() => {
    resolve('i didnt fail you')
 }, 1000);
})
const secondPromise = new Promise((resolve, reject)=>{
    setTimeout(() => {
        reject('I failed you ')
        
    }, 2000);
})

Promise.all([firstPromise, secondPromise]).then((messgae)=>{
console.log('Successful promises',messgae.filter(Boolean))
}).catch((message)=>{
    console.error(message)
})