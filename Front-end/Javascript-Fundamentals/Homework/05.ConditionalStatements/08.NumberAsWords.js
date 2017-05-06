function solve(args) {
	var n = +args[0];
	var onesBig = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];
	var onesSmall = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
	var onesHundrets = ['', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];
	var tensBig = ['', '', 'Twenty', 'Thirty', 'Fourty', 'Fifty', 'Sixty', 'Seventy', 'Eighty', 'Ninety'];
	var tensSmall = ['', '', 'twenty', 'thirty', 'Fourty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];
	var teensBig = ['Ten', 'Eleven', 'Twelve', 'Thirteen', 'Fourteen', 'Fifteen', 'Sixteen', 'Seventeen', 'Eighteen', 'Nineteen'];
	var teensSmall = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];

	//ones
	if (n <= 9) {
		for (var i = 0; i < onesBig.length; i += 1) {
			if (i === n)
				console.log(onesBig[i]);
		}
	} else if (n >= 10 && n <= 19) {
		for (var i = 10; i <= 19; i += 1) {
			if (i === n)
				console.log(teensBig[i - 10]);
		}
		//tens
	} else if (n >= 20 && n <= 99) {
		for (var i = 2; i < tensBig.length; i += 1) {
			if (i === (Math.trunc(n / 10)) % 10) {
				var tens = tensBig[i];
			}
		}
		for (var i = 0; i < onesSmall.length; i += 1) {
			if (i === (Math.trunc(n % 10))) {
				var ones = onesSmall[i];
			}
		}
		console.log(tens + ' ' + ones);
		//hundrets
	} else if (n >= 100 && n <= 999) {
		for (var i = 1; i < onesHundrets.length; i += 1) {
			if (i === (Math.trunc(n / 100)) % 10) {
				var hundrets = onesHundrets[i] + ' ' + 'hundred';
			}
		}
		for (var i = 0; i <= 9; i += 1) {
			if (i === (Math.trunc(n / 10)) % 10) {
				if (i === 0)
					var tens = '';
				else if (i === 1)

					var tens = '';
				else
					var tens = ' and ' + tensSmall[i];
			}
		}
		if (((Math.trunc(n / 10)) % 10) === 0 && (Math.trunc(n % 10)) === 0) {
			var ones = '';
		} else if (((Math.trunc(n / 10)) % 10) === 1) {
			for (var i = 0; i <= 9; i += 1) {
				if (i === (Math.trunc(n % 10)))
					var ones = 'and ' + teensSmall[i];
			}
		} else {
			for (var i = 0; i <= 9; i += 1) {
				if (i === (Math.trunc(n % 10)))
					if (((Math.trunc(n / 10)) % 10) === 0) {
						var ones = 'and ' + onesSmall[i];
					} else {
						var ones = onesSmall[i];
					}
			}

		}
		console.log(hundrets + tens + ' ' + ones);
	}
}
var n = 103;
var onesBig = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];
var onesSmall = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
var onesHundrets = ['', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];
var tensBig = ['', '', 'Twenty', 'Thirty', 'Fourty', 'Fifty', 'Sixty', 'Seventy', 'Eighty', 'Ninety'];
var tensSmall = ['', '', 'twenty', 'thirty', 'Fourty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];
var teensBig = ['Ten', 'Eleven', 'Twelve', 'Thirteen', 'Fourteen', 'Fifteen', 'Sixteen', 'Seventeen', 'Eighteen', 'Nineteen'];
var teensSmall = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];

//ones
if (n <= 9) {
	for (var i = 0; i < onesBig.length; i += 1) {
		if (i === n)
			console.log(onesBig[i]);
	}
} else if (n >= 10 && n <= 19) {
	for (var i = 10; i <= 19; i += 1) {
		if (i === n)
			console.log(teensBig[i - 10]);
	}
	//tens
} else if (n >= 20 && n <= 99) {
	for (var i = 2; i < tensBig.length; i += 1) {
		if (i === (Math.trunc(n / 10)) % 10) {
			var tens = tensBig[i];
		}
	}
	for (var i = 0; i < onesSmall.length; i += 1) {
		if (i === (Math.trunc(n % 10))) {
			var ones = onesSmall[i];
		}
	}
	console.log(tens + ' ' + ones);
	//hundrets
} else if (n >= 100 && n <= 999) {
	for (var i = 1; i < onesHundrets.length; i += 1) {
		if (i === (Math.trunc(n / 100)) % 10) {
			var hundrets = onesHundrets[i] + ' ' + 'hundred';
		}
	}
	for (var i = 0; i <= 9; i += 1) {
		if (i === (Math.trunc(n / 10)) % 10) {
			if (i === 0)
				var tens = '';
			else if (i === 1)

				var tens = '';
			else
				var tens = ' and ' + tensSmall[i];
		}
	}
	if (((Math.trunc(n / 10)) % 10) === 0 && (Math.trunc(n % 10)) === 0) {
		var ones = '';
	} else if (((Math.trunc(n / 10)) % 10) === 1) {
		for (var i = 0; i <= 9; i += 1) {
			if (i === (Math.trunc(n % 10)))
				var ones = 'and ' + teensSmall[i];
		}
	} else {
		for (var i = 0; i <= 9; i += 1) {
			if (i === (Math.trunc(n % 10)))
				if (((Math.trunc(n / 10)) % 10) === 0) {
					var ones = 'and ' + onesSmall[i];
				} else {
					var ones = onesSmall[i];
				}
		}

	}
	console.log(hundrets + tens + ' ' + ones);
}