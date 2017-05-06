"use strict";

function solve(args) {
    //let array = +args[0];
    //let a = +args;
    let a = args[0];
    let b = args[1];
    let c = (Math.sqrt(Math.pow((0 - a), 2) + Math.pow((0 - b), 2)));
    let insideCircle = (c <= 2);
    if (insideCircle) {
        console.log('yes ' + c.toFixed(2));
    //
    // * Returns a string containing a number represented in exponential notation.
    //     * @param fractionDigits Number of digits after the decimal point. Must be in the range 0 - 20, inclusive.
    //     */
    }
    else
        console.log('no ' + c.toFixed(2));
}

console.log(solve(['-2', '0']));