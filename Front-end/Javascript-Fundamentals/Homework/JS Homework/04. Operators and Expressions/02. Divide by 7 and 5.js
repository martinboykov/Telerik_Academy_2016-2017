"use strict";
function solve(args) {
    let a = +args[0];
    if (a % 5 === 0 && a % 7 === 0)
        console.log("true " + a);
    else
        console.log("false " + a);
}
console.log(solve([1]));