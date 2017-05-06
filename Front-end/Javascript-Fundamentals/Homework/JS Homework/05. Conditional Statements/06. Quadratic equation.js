/**
 * Created by martinboykov on 1/6/2017.
 */
'use strict';
function solve(args) {
    let a = +args[0],
        b = +args[1],
        c = +args[2],
        root1,
        root2;
    let discriminant = Math.pow(b, 2) - (4 * a * c);
    if (discriminant < 0) {
        console.log('no real roots');
    } else if (discriminant === 0) {
        root1 = -b / (2 * a);
        console.log('x1=x2=' + root1.toFixed(2));
    } else {
        root1 = (-b + Math.sqrt(discriminant)) / (2 * a);
        root2 = (-b - Math.sqrt(discriminant)) / (2 * a);
        console.log('x1=' + Math.min(root1, root2).toFixed(2) + '; ' + 'x2=' + Math.max(root1, root2).toFixed(2));
    }
}
console.log(solve(['5', '2', '8']));