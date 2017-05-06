function solve(args) {
	var array = (args + '').split('\n').map(Number),
		frequenNumber = 0, 
		frequenNumberCount = 0, 
		mostFrequentNumber = 0, 
		mostFrequentNumberCount = 0;

	array.splice(0, 1);

	length = array.length;
	for (var i = 0; i < length; i+=1) {
		for (var j = 0; j < length; j+=1) {
			frequenNumber = array[i];
			if (frequenNumber === array[j]) {
				frequenNumberCount+=1;
			}
		}
		if (mostFrequentNumberCount < frequenNumberCount) {
			mostFrequentNumberCount = frequenNumberCount;
			mostFrequentNumber = frequenNumber;
		}
		frequenNumberCount = 0;
	}
	console.log(mostFrequentNumber + " (" + mostFrequentNumberCount + " times)");
}
var input = ['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3'];

solve(input);