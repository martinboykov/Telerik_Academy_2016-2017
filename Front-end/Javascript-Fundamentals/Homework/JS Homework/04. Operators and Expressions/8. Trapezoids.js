"use strict";

function solve(args) {
    let a = +args[0];
    let b = +args[1];
    let h = +args[2];
    let result = h * ((a + b) / 2);
    console.log(result.toFixed(7));
    /**
     * Returns a string containing a number represented in exponential notation.
     * @param fractionDigits Number of digits after the decimal point. Must be in the range 0 - 20, inclusive.
     */
}
console.log(solve(['0.222', '0.333', '0.555']));