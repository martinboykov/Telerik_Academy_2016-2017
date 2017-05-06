function solve(args) {
	var n = new Array(3);
	for (var i = 0; i < 3; i += 1) {
		n[i] = +args[i];
	}
	a = n[0];
	b = n[1];
	c = n[2];
	var root1;
	var root2;
	var discriminant = Math.pow(b, 2) - (4 * a * c);
	if (discriminant < 0) {
		console.log('no real roots');
	} else if (discriminant === 0) {
		root1 = -b / (2 * a);
		console.log('x1=x2=' + root1.toFixed(2));
	} else {
		root1 = (-b + Math.sqrt(discriminant)) / (2 * a);
		root2 = (-b - Math.sqrt(discriminant)) / (2 * a)
		console.log('x1=' + Math.min(root1, root2).toFixed(2) + '; ' + 'x2=' + Math.max(root1, root2).toFixed(2));
	}
}

//calculations
var n = new Array(3);
n[0] = 2;
n[1] = 5;
n[2] = -3;
a = n[0];
b = n[1];
c = n[2];
var root1;
var root2;
var discriminant = Math.pow(b, 2) - (4 * a * c);
console.log(discriminant);
if (discriminant < 0) {
	console.log('no real roots');
} else if (discriminant === 0) {
	root1 = -b / (2 * a);
	console.log('x1=x2=' + root1.toFixed(2));
} else {
	root1 = (-b + Math.sqrt(discriminant)) / (2 * a);
	root2 = (-b - Math.sqrt(discriminant)) / (2 * a)
	console.log('x1=' + Math.min(root1, root2).toFixed(2) + '; ' + 'x2=' + Math.max(root1, root2).toFixed(2));
}