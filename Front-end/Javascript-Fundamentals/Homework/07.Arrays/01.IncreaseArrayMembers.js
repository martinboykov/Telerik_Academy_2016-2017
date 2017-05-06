function solve(args) {
	var n = +args[0];
	var array = new Array(n);
	for (var i = 0; i < array.length; i += 1) {
		array[i] = i * 5;
		console.log(array[i]);
	}
}
var array = new Array(2);
for (var i = 0; i < array.length; i += 1) {
	array[i] = i * 5;
	console.log(array[i]);
}