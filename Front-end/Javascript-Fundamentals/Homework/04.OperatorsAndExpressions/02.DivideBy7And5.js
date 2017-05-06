function solve(args) {
	var a = +args[0];
	if (a % 5 === 0 && a % 7 === 0)
		console.log("true " + a);
	else
		console.log("false " + a);
}
var a = 140;
if (a % 5 === 0 && a % 7 === 0)
	console.log("true " + a);
else
	console.log("false " + a);