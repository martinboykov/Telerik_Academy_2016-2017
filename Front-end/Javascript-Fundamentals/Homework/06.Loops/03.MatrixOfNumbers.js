function solve(args) {
	var n = +args[0];

	if (1 <= n & n <= 100) {
		for (var row = 1; row < n + 1; row += 1) {
			var result = '';
			result += row + " ";
			for (var col = row + 1; col < n + row; col += 1) {
				result += col + " ";
			}
			console.log(result);
		}
	}
}
var n = 4;

if (1 <= n & n <= 100) {
	for (var row = 1; row < n + 1; row += 1) {
		var result = '';
		result += row + " ";
		for (var col = row + 1; col < n + row; col += 1) {
			result += col + " ";
		}
		console.log(result);
	}
}