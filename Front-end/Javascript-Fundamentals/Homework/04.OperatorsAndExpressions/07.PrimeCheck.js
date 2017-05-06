function solve(args) {
	var a = +args[0];
	var ifPrime = true;
	if (a < 0) {
		ifPrime = false;
	} else {
		if (a === 0 || a === 1)
			ifPrime = false;
		for (var i = 2; i < a; i += 1) {
			if (a % i === 0) {
				ifPrime = false;
				break;
			}
		}
	}
	console.log(ifPrime)
}
// int N = int.Parse(Console.ReadLine());
//         bool ifPrime = true;

//         if (N > 0 && N <= 100)
//         {
//             if (N==1)
//             {
//                 ifPrime = false;
//             }
//             if (N==2)
//             {
//                 ifPrime = true;
//             }
//             for (int i = 2; i < N; i++)
//             {
//                 if (N % i == 0)
//                 {
//                     ifPrime = false;
//                 }
//             }
//         }
//         else
//         {
//             ifPrime = false;
//         }
//         if (ifPrime)
//         {
//             Console.WriteLine("true");
//         }
//         else
//         {
//             Console.WriteLine("false");
//         }
var a = 23;
var ifPrime = true;
if (a < 0) {
	ifPrime = false;
} else {
	if (a === 0 || a === 1)
		ifPrime = false;
	for (var i = 2; i < a; i += 1) {
		if (a % i === 0) {
			ifPrime = false;
			break;
		}
	}


}
console.log(ifPrime)