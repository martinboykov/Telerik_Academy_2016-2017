/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */

function sum() {
    return function (arr) {
        if (arr.length === 0) {
            return null;
        }
        let arrLength = arr.length;
       /* let sum = 0;*/
        for (let i = 0; i < arrLength; i += 1) {
            if (isNaN(Number(arr[i]))) {
                throw "Argument exception"
            }
            /*sum += arr[i] | 0;*/
        }
        return arr.map(Number).reduce(function add(a, b) {
            return a + b;
        }, 0);
        /*return sum;*/
    }
}

module.exports = sum;