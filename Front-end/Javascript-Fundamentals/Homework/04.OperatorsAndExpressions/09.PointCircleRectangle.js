function solve(args) {
	var x = +args[0];
	var y = +args[1];
	var insideCircle = (Math.sqrt(Math.pow((x - 1), 2) + Math.pow((y - 1), 2)) <= 1.5);
	var insideRectangle = ((x >= -1) & (x <= 5) & (y >= -1) & (y <= 1));
	if (insideCircle && insideRectangle) {
		console.log("inside circle inside rectangle");
	} else if (insideCircle && !insideRectangle) {
		console.log("inside circle outside rectangle");
	} else if (!insideCircle && insideRectangle) {
		console.log("outside circle inside rectangle");
	} else if (!insideCircle && !insideRectangle) {
		console.log("outside circle outside rectangle");
	}
}
// double x = double.Parse(Console.ReadLine());
// double y = double.Parse(Console.ReadLine());
// bool insideCircle = (Math.Sqrt(Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2)) <= 1.5);
// bool insideRectangle = ((x >= -1) & (x <= 5) & (y >= -1) & (y <= 1));
// if (insideCircle && insideRectangle)
// {
//     Console.WriteLine("inside circle inside rectangle");
// }
// else if (insideCircle && !insideRectangle)
// {
//     Console.WriteLine("inside circle outside rectangle");
// }
// else if (!insideCircle && insideRectangle)
// {
//     Console.WriteLine("outside circle inside rectangle");
// }
// else if (!insideCircle && !insideRectangle)
// {
//     Console.WriteLine("outside circle outside rectangle");
// }
var x = 1;
var y = 2;
var insideCircle = (Math.sqrt(Math.pow((x - 1), 2) + Math.pow((y - 1), 2)) <= 1.5);
var insideRectangle = ((x >= -1) & (x <= 5) & (y >= -1) & (y <= 1));
if (insideCircle && insideRectangle) {
	console.log("inside circle inside rectangle");
} else if (insideCircle && !insideRectangle) {
	console.log("inside circle outside rectangle");
} else if (!insideCircle && insideRectangle) {
	console.log("outside circle inside rectangle");
} else if (!insideCircle && !insideRectangle) {
	console.log("outside circle outside rectangle");
}