function solve(args) {
	var numbs = new Array(3);
	// numbs[0] = -1;
	// numbs[1] = -0.5;
	// numbs[2] = -5.1;
	var countNegative = 0;
	var countZero = 0;
	for (var i = 0; i < 3; i += 1) {
		numbs[i] = +args[i];
		if (numbs[i] == 0) {
			countZero += 1;
		} else if (numbs[i] < 0) {
			countNegative += 1;
		}
	}
	if (countZero > 0) {
		console.log("0");
	} else if ((countNegative === 0) || (countNegative % 2 === 0)) {
		console.log("+");
	} else {
		console.log("-");
	}
}
// double[] numbs = new double[3];
// int countNegative = 0;
// int countZero = 0;
// for (int i = 0; i < 3; i++)
// {
//     numbs[i] = double.Parse(Console.ReadLine());
//     if (numbs[i] == 0)
//     {
//         countZero++;
//     }
//     else if (numbs[i] < 0)
//     {
//         countNegative++;
//     }
// }
// if (countZero > 0)
// {
//     Console.WriteLine("0");
// }
// else if ((countNegative == 0) || (countNegative % 2 == 0))
// {
//     Console.WriteLine("+");
// }
// else
// {
//     Console.WriteLine("-");
// }
var numbs = new Array(3);
numbs[0] = -1;
numbs[1] = -0.5;
numbs[2] = -5.1;
var countNegative = 0;
var countZero = 0;
for (var i = 0; i < 3; i += 1) {
	// numbs[i] = 5;
	if (numbs[i] == 0) {
		countZero += 1;
	} else if (numbs[i] < 0) {
		countNegative += 1;
	}
}
if (countZero > 0) {
	console.log("0");
} else if ((countNegative === 0) || (countNegative % 2 === 0)) {
	console.log("+");
} else {
	console.log("-");
}