/**
 * Created by martinboykov on 1/6/2017.
 */
'use strict';

function solve(args) {
    let biggestNumber = -(Math.pow(2,28));
    for (let i = 0; i < 3; i += 1) {
        if (+args[i]> biggestNumber) {
            biggestNumber = args[i];
        }
    }
    console.log(biggestNumber);
}

console.log(solve(['-111111', '-1.01', '-2']));

//console.log(Math.max(n[0],n[1],n[2]));