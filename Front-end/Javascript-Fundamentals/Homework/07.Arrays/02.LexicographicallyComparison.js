function solve(args) {
	var str = args[0].split('\n');
	var charArrayFirst = str[0];
	var charArraySecond = str[1];
	var shorterLength = 0;
	var bigger = false; // >
	var smaller = false; // <
	var lengthDifference = false;
	if (charArrayFirst.length > charArraySecond.length) {
		shorterLength = charArraySecond.length;
	} else {
		shorterLength = charArrayFirst.length;
	}
	if (charArrayFirst.length > charArraySecond.length) {
		console.log(">");
		lengthDifference = true;
	} else if (charArrayFirst.length < charArraySecond.length) {
		console.log("<");
		lengthDifference = true
	} else {
		for (var i = 0; i < shorterLength; i++) {
			if (charArrayFirst[i] > charArraySecond[i]) {
				bigger = true;
				break;
			} else if (charArrayFirst[i] < charArraySecond[i]) {
				smaller = true;
				break;
			}
		}
	}
	if (bigger) {
		console.log(">");
	} else if (smaller) {
		console.log("<");
	} else if (!lengthDifference) {
		console.log("=");
	}

}
var charArrayFirst = ['s', 'h', 'a', 'a', 'b', 'c', 'd'];
var charArraySecond = ['p', 'g', 'p', 'e', 's', 'h', 'a'];
var shorterLength = 0;
var bigger = false; // >
var smaller = false; // <
var lengthDifference = false;
if (charArrayFirst.length > charArraySecond.length) {
	shorterLength = charArraySecond.length;
} else {
	shorterLength = charArrayFirst.length;
}
if (charArrayFirst.length > charArraySecond.length) {
	console.log(">");
	lengthDifference = true;
} else if (charArrayFirst.length < charArraySecond.length) {
	console.log("<");
	lengthDifference = true
} else {
	for (var i = 0; i < shorterLength; i++) {
		if (charArrayFirst[i] > charArraySecond[i]) {
			bigger = true;
			break;
		} else if (charArrayFirst[i] < charArraySecond[i]) {
			smaller = true;
			break;
		}
	}
}
if (bigger) {
	console.log(">");
} else if (smaller) {
	console.log("<");
} else if (!lengthDifference) {
	console.log("=");
}