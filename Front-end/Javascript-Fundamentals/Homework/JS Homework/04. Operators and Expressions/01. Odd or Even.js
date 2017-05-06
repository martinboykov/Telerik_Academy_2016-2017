"use strict";
function solve(args) {
    let a = +args[0];
    if (a % 2 === 0)
        console.log("even " + a);
    else
        console.log(("odd " + a))
}
console.log(solve([1]));
