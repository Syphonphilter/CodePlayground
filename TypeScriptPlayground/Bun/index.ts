const server = Bun.serve({
    port: 5001,
    fetch(req) {
    return new Response('Hello')
    }
})
console.log(`listening on port ${server.port}}`)