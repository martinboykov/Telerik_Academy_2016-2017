/**
 * Created by martinboykov on 1/6/2017.
 */
'use strict';
function solve(args) {
    let a = args[0];
    let b = args[1];
    if (a > b) {
        console.log(`${b} ${a}`);
    } else {
        console.log(`${a} ${b}`);
    }
}

console.log(solve(['5.5', '4.5']));