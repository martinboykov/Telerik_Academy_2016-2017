function solve(args) {
	var n = new Array(3);
	var sum = 0;
	for (var i = 0; i < 3; i += 1) {
		n[i] = +args[i];
		sum += n[i];
	}
	var max = Math.max(n[0], n[1], n[2]);
	var min = Math.min(n[0], n[1], n[2]);
	var middle = sum - max - min;
	console.log(max + " " + middle + " " + min);
}
var n = new Array(3);
n[0] = 0;
n[1] = -2.5;
n[2] = 5;
var sum = 0;
for (var i = 0; i < n.length; i += 1) {
	sum += n[i];
}
var max = Math.max(n[0], n[1], n[2]);
var min = Math.min(n[0], n[1], n[2]);
var middle = sum - max - min;
console.log(max + " " + middle + " " + min);