var fs = require("fs");

fs.readFile("file.txt", "utf8", function (error, data) {
    if (error) {
        throw error;
    }

    console.log(data.toString());
})

fs.writeFile("file2.txt", "This row wrote with fs module", function (error) {
    if (error) {
        throw error;
    }

    console.log("Write");
})

fs.appendFile("file2.txt", "\rWe are learning Node.JS", function (error) {
    if (error) {
        throw error;
    }

    console.log("Append");
})

fs.unlink("file2.txt", function (error) {//Delete File
    if (error) {
        throw error;
    }

    console.log("Delete");
})

// npm install {node}@{1.1.0}   // -g (represents global for all projects)
// npm init -y                  // y=>base template
// npm install --save-dev       // dev dependencies
// npm outdate                  // compare installed with last version packages
// npm install nodeman