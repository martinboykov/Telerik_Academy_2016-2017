function solve(args) {
	var input = (args + '').split(','),
		array = (input[1] + '').split(' ').map(Number).sort(function compareNumbers(a, b) {
  return a - b;
}).join(' ');
		console.log(array);
}
var input = ['6', '3 4 1 5 2 6'];
solve(input)