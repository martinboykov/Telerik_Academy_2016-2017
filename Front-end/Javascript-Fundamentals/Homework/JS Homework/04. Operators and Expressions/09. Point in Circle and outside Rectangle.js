"use strict";

function solve(args) {
    let x = +args[0];
    let y = +args[1];
    let insideCircle = (Math.sqrt(Math.pow((x - 1), 2) + Math.pow((y - 1), 2)) <= 1.5);
    let insideRectangle = ((x >= -1) && (x <= 5) && (y >= -1) && (y <= 1));
    if (insideCircle && insideRectangle) {
        console.log("inside circle inside rectangle");
    } else if (insideCircle && !insideRectangle) {
        console.log("inside circle outside rectangle");
    } else if (!insideCircle && insideRectangle) {
        console.log("outside circle inside rectangle");
    } else if (!insideCircle && !insideRectangle) {
        console.log("outside circle outside rectangle");
    }
}
console.log(solve(['2.5', '2']));