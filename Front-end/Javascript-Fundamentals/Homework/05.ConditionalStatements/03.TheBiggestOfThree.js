function solve(args) {
	var n = new Array(3);
	for (var i = 0; i < 3; i += 1) {
		n[i] = +args[i];
	}
	console.log(Math.max(n[0],n[1],n[2]));
}
var n = new Array(3);
n[0] = -2;
n[1] = -2;
n[2] = 1;
console.log(Math.max(n[0],n[1],n[2]));