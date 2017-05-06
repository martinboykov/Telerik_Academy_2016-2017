function solve(args) {
	var input = (args + '').split(','),
		array = (input[1] + '').split(' ').map(Number);

		console.log((input[1] + '').split(' '));console.log((input[1]).split(' '));
	length = array.length;
	count = 0;
	found = false;

	for (var i = 1; i < length - 1; i += 1) {

		if (array[i - 1] < array[i] && array[i] > array[i + 1]) {
			found = true;
			console.log(i);
			break ;
		}
	}
	if (!found) {
		console.log(-1);
	}
}
var input = ['6,-26 -25 -28 31 2 27'];
solve(input)