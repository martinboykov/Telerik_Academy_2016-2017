function solve(args) {
	var array = (args + '').split('\n').map(Number);
	array.shift();
	var count = 0;
	var countMax = 0;
	var current = array[0];
	var len = array.length;
	for (var i = 1; i < len; i += 1) {
		if (array[i] !== current) {
			count = 0;
			current = array[i];
			count += 1;
		} else {
			count += 1;
			if (count > countMax) {
				countMax = count;
			}
		}
	}
	console.log(countMax);
}
var N = ['10','2', '1', '1', '2', '3', '3', '2', '2', '2', '1'];
var array = N.split(',').map(Number);
console.log(array);
array.shift();
console.log(array);
var count = 0;
var countMax = 0;
var current = array[0];
for (var i = 1; i < N; i += 1) {

	if (array[i] !== current) {
		count = 0;
		current = array[i];
		count += 1;
	} else {
		count += 1;
		if (count > countMax) {
			countMax = count;
		}
	}
}
console.log(countMax);