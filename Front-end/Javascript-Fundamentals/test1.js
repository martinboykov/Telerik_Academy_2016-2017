function solve(args) {
    var line1 = args[0].split(" ");
    var R = line1[0];
    var C = line1[1];
    var lab = args.slice(1).map(function (line) {
        return line.split(' ');
    });


    var row = R / 2 | 0;
    var col = C / 2 | 0;
    var startPosition = [row, col]; //[row, col]
    var currentPosition = startPosition;
    var pad = "0000";

    while (true) {
        if (!lab[row] || !lab[row][col]) {
            return console.log('No rakiya, only JavaScript ' + row +' '+ col);
        }
        var strDir = (lab[row][col] | 0).toString(2);
        var direction = pad.substring(0, pad.length - strDir.length) + strDir;
        if (direction[3] == 1 && lab[row - 1][col] !== "visited") {
            row-=1;
        } else if (direction[2] == 1 && lab[row][col + 1] !== "visited") {
            col += 1;
        } else if (direction[1] == 1 && lab[row + 1][col] !== "visited") {
            row += 1;
        } else if (direction[0] == 1 && lab[row][col - 1] !== "visited") {
            col -= 1;
        } else {
            return console.log('No JavaScript, only rakiya ' + row +' '+ col);
        }
        lab[row][col] = 'visited';
    }
}