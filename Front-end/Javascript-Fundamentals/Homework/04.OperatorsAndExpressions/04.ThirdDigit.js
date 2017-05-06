function solve(args) {
	var a = +args[0];
	var b = (Math.trunc(a / 100)) % 10;
if (b === 7)
	console.log('true');

else
	console.log('false ' + b);
}
// int N = int.Parse(Console.ReadLine());
//         if (N > 99)
//         {
//             if ((N / 100) % 10 == 7)
//             {
//                 Console.WriteLine("true ");
//             }
//             else
//             {
//                 Console.WriteLine("false {0}", (N / 100) % 10);
//             }
//         }
//         else
//         {
//             Console.WriteLine("false {0}", (N / 100) % 10);
//         }

var a = 9999799;
console.log((a / 100));
console.log((a / 100) % 10);
console.log(Math.trunc(a / 100) % 10);
var b = (Math.trunc(a / 100)) % 10;
if (b === 7)
	console.log('true');

else
	console.log('false ' + b);