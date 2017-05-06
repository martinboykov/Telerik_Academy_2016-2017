function solve(args) {
    "use strict";
    var n = args[0], numbers = [], result; //CHECK IT !!!!!!!!
    for (let i = 1; i <= n; i += 1) {
        numbers.push(args[i] | 0)
    }
    if (numbers[0] % 2 > 0) {//odd
        result = 1;
    } else { //even
        result = 0;
    }
    var len = numbers.length;
    for (let i = 0; i <= len; i += 1) {
        if (numbers[i] % 2 > 0) { //odd
            result *= numbers[i];
        } else if (numbers[i] % 2 == 0) { //even
            result += numbers[i];
            i += 1;
        }
        if (result >= 1024) { ////check if also === 1024
            result %= 1024;
        }
    }
    console.log(result);
}

solve([
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9'
]);