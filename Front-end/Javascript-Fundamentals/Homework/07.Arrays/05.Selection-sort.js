function solve(args) {
	var array = (args + '').split('\n').map(Number),
	tmp, minIndex, min, len;

	array.splice(0, 1);
	len = array.length;

	for (var j = 0; j < len; j += 1) {
		min = array[j];
		minIndex = j; //sets the position at index 'j'

		for (var k = j + 1; k < len; k+=1) {
			if (array[k] < min) {
				min = array[k];
				minIndex = k; //when/if it finds smaller number sets the position at index 'k' of the smaller number
			}
		}
		tmp = array[minIndex];
		array[minIndex] = array[j]; //swap positions
		array[j] = tmp; //swap positions
	}
	console.log(array.join('\n'));//faster than for-loop
}
var input = ['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20'];

solve(input);