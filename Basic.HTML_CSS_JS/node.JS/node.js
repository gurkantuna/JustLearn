var http = require("http");
var log = require("./log.js");
var saySomething = require("./exportDemo.js");

http.createServer(function (request, response) {

    console.log(request.url);

    // if (request.url == "/admin") {
    //     response.writeHead(200, {
    //         "Content-Type": "application/json"
    //     }),
    //         response.write("<html><body><p><strong>Admin Page</strong></p></body></html>");
    // }
    // else if (request.url == "/") {
    //     response.writeHead(200, {
    //         "Content-Type": "application/json"
    //     }),
    //         response.write("<html><body><p><strong>Home Page</strong></p></body></html>");
    // }
    // else if (request.url == "customer") {
    //     response.writeHead(200, {
    //         "Content-Type": "application/json"
    //     });
    //     response.write(JSON.stringify({
    //         name: 'Gürkan',
    //         lastName: 'Tuna'
    //     }))
    // }
    // response.end("End of page");

    if (request.url == "/admin") {
        response.writeHead(200, { "Content-Type": "text/html" });
        response.write("<html><body>Admin Page</body></html>");
    }
    else if (request.url == "/customer") {
        response.writeHead(200, { "Content-Type": "application/json" });
        response.write(JSON.stringify(
            {
                name: "Gürkan",
                lastName: "Tuna"
            }
        ));
    }
    else {
        response.writeHead(200, { "Content-Type": "text/html" });
        response.write("<html><body>Home Page</body></html>")
    }

    response.end("End of Page");

}).listen(8080);

log.error("beautiful error :) ");
console.log(saySomething("Hello World"));
