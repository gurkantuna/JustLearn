//import { Module } from "module";

var log = {
    information: function (info) {
        console.log("Information : " + info);
    },
    error: function (fault) {
        console.log("Error : " + fault)
    }
};

module.exports = log;
