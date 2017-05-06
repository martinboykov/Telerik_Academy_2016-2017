function solve(args) {
	var a = +args[0];
	var b = 8;
	if ((a & b) === 8)
		console.log(1);

	else
		console.log(0);
}
// long number = Int64.Parse(Console.ReadLine());
//         long mask = 8;
//         if (number > 0)
//         {
//             bool check = (number & mask) == 8;
//             if (check)
//             {
//                 Console.WriteLine(1);
//             }
//             else
//             {
//                 Console.WriteLine(0);
//             }
//         }
var a = 1024;
var b = 8;
if ((a & b) === 8)
	console.log(1);

else
	console.log(0);