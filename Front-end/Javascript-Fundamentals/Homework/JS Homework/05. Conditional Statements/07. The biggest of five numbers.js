/**
 * Created by martinboykov on 1/6/2017.
 */
'use strict';

function solve(args) {
    let array = [];
    for (let i = 0; i < 5; i += 1) {
        array[i] = +args[i];
    }
    let max = Math.max(array[0], array[1], array[2], array[3], array[4])
    console.log(max);
}

