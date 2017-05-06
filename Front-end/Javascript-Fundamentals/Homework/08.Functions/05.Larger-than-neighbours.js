function solve(args) {
	var input = (args + '').split(','),
		array = (input[1] + '').split(' ').map(Number);
	length = array.length;
	count = 0;
	for (var i = 1; i < length - 1; i += 1) {
		if (array[i - 1] < array[i] && array[i] > array[i + 1]) {
			count += 1;
		}
	}
	console.log(count);
}
var input = ['6,-26 -25 -28 31 2 27'];
solve(input)