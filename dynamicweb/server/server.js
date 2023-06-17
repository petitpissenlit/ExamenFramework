const http = require('http'); //build-in nodejs package

const server = http.createServer(function (request, response) {
    console.log('Server is running!');
    response.write('welcome!');
    response.end();
})
server.listen(3000);