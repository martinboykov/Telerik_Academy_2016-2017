function solve(input) {
	var name = (input + '').split(' ').map(Number);
	console.log(Math.max(name[0], name[1], name[2]));
}
var input = '7 19 19';
solve(input);