function solve(args) {
	var array = new Array(5);
	for (var i = 0; i < array.length; i += 1) {
		array[i] = +args[i];
	}
	var max = Math.max(array[0], array[1], array[2], array[3], array[4])
	console.log(max);

}
var array = new Array(5);
array[0] = 5;
array[1] = 2;
array[2] = 2;
array[3] = 4;
array[4] = 1;

var max = Math.max(array[0], array[1], array[2], array[3], array[4])
console.log(max);

// with  Selection sort algorithm
//var array = new Array(5);
// for (var i = 0; i < array.length; i++) {
// 	array[i] = +args[i];
// }
// array[0] = 5;
// array[1] = 2;
// array[2] = 2;
// array[3] = 4
// array[4] = 1;
// var tmp, min_key;
// for (var j = 0; j < array.length - 1; j += 1) {
// 	min_key = j; //sets the position at index 'j'

// 	for (var k = j + 1; k < array.length; k++) {
// 		if (array[k] < array[min_key]) {
// 			min_key = k; //when/if it finds smaller number sets the position at index 'k' of the smaller number
// 		}
// 	}
// 	tmp = array[min_key];
// 	array[min_key] = array[j]; //swap positions
// 	array[j] = tmp; //swap positions
// }

// for (var i = 0; i < array.length; i++) {
// 	console.log(array[i]);
// }