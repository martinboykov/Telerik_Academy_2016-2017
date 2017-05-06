function solve(args) {
	var a = +args[0];
	var b = +args[1];
var c = (Math.sqrt(Math.pow((0 - a), 2) + Math.pow((0 - b), 2)));
var insideCircle = (c <= 2);
if (insideCircle) {
	console.log('yes ' + c.toFixed(2));
	}
	else
		console.log('no ' + c.toFixed(2));
}
// if (Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2)) <= 2)
//         {
//             Console.WriteLine("yes {0:F2}", Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2)));
//         }
//         else
//         {
//             Console.WriteLine("no {0:F2}", Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2)));
//         }
var a = 0;
var b = 1;
var c = (Math.sqrt(Math.pow((0 - a), 2) + Math.pow((0 - b), 2)));
var insideCircle = (c <= 2);
if (insideCircle) {
	console.log('yes ' + c.toFixed(2));
	}
	else
		console.log('no ' + c.toFixed(2));
		