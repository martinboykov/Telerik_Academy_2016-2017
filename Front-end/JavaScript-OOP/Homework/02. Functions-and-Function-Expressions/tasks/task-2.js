/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes() {
    return function solve(a, b) {
        if (a=== undefined || b === undefined) {
            throw "ERROR"
        }
        a = +a;
        b = +b;

        var primes = [];
        var isPrime = true;
        for (let i = a; i <= b; i += 1) {
            if ((i < 0) || (i === 0) || (i === 1)) {
                isPrime = false;
            }
            for (let j = 2; j <= Math.sqrt(i); j += 1) {
                if (i % j === 0) {
                    isPrime = false;
                }
            }
            if (isPrime) {
                primes.push(i);
            }
            isPrime = true;
        }
        return primes;
    }
}

module.exports = findPrimes;
