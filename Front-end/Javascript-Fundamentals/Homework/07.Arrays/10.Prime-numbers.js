function solve(input) {
	var n = +input;

	var maxPrime = 2;
	var isPrime = true;
	for (var i = n; i > maxPrime; i-=1) {
		var sqrt = Math.sqrt(i);
		for (var j = 2; j <= sqrt; j+=1) {
			if (i % j === 0) {
				isPrime = false;
				break;
			}
		}
		if (isPrime) {
			maxPrime = i;
		}
		isPrime = true;
	}
	console.log(maxPrime);
}
var input = 13;
solve(input);