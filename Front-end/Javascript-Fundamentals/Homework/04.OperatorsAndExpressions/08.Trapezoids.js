function solve(args) {
	var a = +args[0];
	var b = +args[1];
	var h = +args[2];
	var result = h * ((a + b) / 2);
	console.log(result.toFixed(7));
}
// double a = double.Parse(Console.ReadLine());
// double b = double.Parse(Console.ReadLine());
// double h = double.Parse(Console.ReadLine());
// Console.WriteLine("{0:F7}", (h * ((a + b) / 2)));
var a = 5;
var b = 7;
var h = 12;
var result = h * ((a + b) / 2);
console.log(result.toFixed(7));