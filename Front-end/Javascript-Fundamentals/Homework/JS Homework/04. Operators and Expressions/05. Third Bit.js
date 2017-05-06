"use strict";
va
function solve(args) {
    let a = +args[0];
    let b = 8;
    console.log((8).toString(2));
    // 8   === 0001000
    //15   === 0001111
    //8&15 === 0001000
    if ((a & b) === 8)

        console.log(1);

    else
        console.log(0);
}
console.log(solve([15]));

