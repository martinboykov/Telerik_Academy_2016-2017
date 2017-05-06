/**
 * Created by martinboykov on 1/6/2017.
 */
'use strict';

function solve(args) {
    let array = [args[0],args[1],args[2]];
    let product = array.reduce(function (a,b) {
        return a*b;
    },1);
    if(product>0)
        console.log('+');
    else if (product===0)
        console.log('0');
    else
        console.log('-');
}
console.log(solve(['0', '-2', '1']));

// let a = +args[0];
// let b = +args[1];
// let c = +args[2];

// let countNegative = 0;
// let countZero = 0;
// for (let i = 0; i < 3; i += 1) {
//     numbs[i] = +args[i];
//     if (numbs[i] == 0) {
//         countZero += 1;
//     } else if (numbs[i] < 0) {
//         countNegative += 1;
//     }
// }
// if (countZero > 0) {
//     console.log("0");
// } else if ((countNegative === 0) || (countNegative % 2 === 0)) {
//     console.log("+");
// } else {
//     console.log("-");
// }
