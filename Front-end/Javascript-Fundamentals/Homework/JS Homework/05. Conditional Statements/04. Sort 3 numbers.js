/**
 * Created by martinboykov on 1/6/2017.
 */
'use strict';

function solve(args) {
    let sum = 0;
    for (let i = 0; i < 3; i += 1) {
        sum += +args[i];
    }
    let max = Math.max(+args[0], +args[1], +args[2]);
    let min = Math.min(+args[0], +args[1], +args[2]);
    let middle = sum - max - min;
    console.log(max + " " + middle + " " + min);
}
console.log(solve(['5', '1', '2']));