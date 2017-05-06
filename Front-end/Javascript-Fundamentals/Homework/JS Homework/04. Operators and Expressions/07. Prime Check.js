"use strict";

function solve(args) {
    let a = args[0];
    let ifPrime = true;
    if ((a < 0) || (a === 0) || (a === 1)) {
        ifPrime = false;
    } else {
        for (let i = 2; i < (a); i += 1) {
            if (a % i === 0) {
                ifPrime = false;
               return  console.log(ifPrime);
            }
        }
    }
    console.log(ifPrime)
}
console.log(solve([0]));
