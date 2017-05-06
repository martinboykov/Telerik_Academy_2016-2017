"use strict";
function solve(args) {
    //var array = +args[0];
    //var a = +args;
    //var b = +args;
    let a = +args[0];
    let b = +args[1];
    console.log((a*b).toFixed(2) + " "
        + (2*a + 2*b).toFixed(2));
}

console.log(solve([5,5]));