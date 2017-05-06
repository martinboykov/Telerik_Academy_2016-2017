/**
 * Created by martinboykov on 1/18/2017.
 */
function solve(args) {
    var line1 = args[0].split(" "),
        R = line1[0] | 0,
        C = line1[1] | 0,
        lab = args.slice(1).map(function (line) {
            return line.split(' ').map(Number);
        }),
        pad = "0000",
        row = R / 2 | 0,
        col = C / 2 | 0,
        rowTemp = row,
        colTemp = col,
        outside = false,
        visited = false,
        labVisited = [];
    for (let i = 0; i < R; i += 1) {
        let rowArray = new Array(C);
        rowArray.fill(false);
        labVisited.push(rowArray);
    }
    
    
    var strDir = (lab[row][col]).toString(2);
    var direction = pad.substring(0, pad.length - strDir.length) + strDir;

    function checkOutside(rowTemp, colTemp) {
        if (rowTemp < 0 || rowTemp > R - 1 || colTemp < 0 || colTemp > C - 1) {
            return true;
        }
        else return false;
    }


    function checkVisited(rowTemp, colTemp) {
        if (labVisited[rowTemp][colTemp] === true) {
            return true;
        }
        labVisited[rowTemp][colTemp] = true;
        return false;
    }

    while (true) {

        strDir = (lab[row][col]).toString(2);
        direction = pad.substring(0, pad.length - strDir.length) + strDir;
        labVisited[row][col] = true;
        if (direction[3] == 1) {
            rowTemp -= 1;
            if (checkOutside(rowTemp, colTemp)) {
                console.log('No rakiya, only JavaScript ' + row + ' ' + col);
                break;
            }
            if (!checkVisited(rowTemp, colTemp)) {
                row -= 1;
                continue;
            }
            rowTemp += 1;
        }

        if (direction[2] == 1) {
            colTemp += 1;
            if (checkOutside(rowTemp, colTemp)) {
                console.log('No rakiya, only JavaScript ' + row + ' ' + col);
                break;
            }
            if (!checkVisited(rowTemp, colTemp)) {
                col += 1;
                continue;
            }
            colTemp -= 1;
        }

        if (direction[1] == 1) {
            rowTemp += 1;
            if (checkOutside(rowTemp, colTemp)) {
                console.log('No rakiya, only JavaScript ' + row + ' ' + col);
                break;
            }
            if (!checkVisited(rowTemp, colTemp)) {
                row += 1;
                continue;
            }
            rowTemp -= 1;
        }

        if (direction[0] == 1) {
            colTemp -= 1;
            if (checkOutside(rowTemp, colTemp)) {
                console.log('No rakiya, only JavaScript ' + row + ' ' + col);
                break;
            }
            if (!checkVisited(rowTemp, colTemp)) {
                col -= 1;
                continue;
            }
            colTemp += 1;

        }
        console.log('No JavaScript, only rakiya ' + row + ' ' + col);
        break;
    }
}


solve([
    '5 7',
    '9 5 3 11 9 5 3',
    '10 11 10 12 4 3 10',
    '10 10 12 7 13 6 10',
    '12 4 3 9 5 5 2',
    '13 5 4 6 13 5 6'
]);

solve([
    '7 5',
    '9 3 11 9 3',
    '10 12 4 6 10',
    '12 3 13 1 6',
    '9 6 11 12 3',
    '10 9 6 13 6',
    '10 12 5 5 3',
    '12 5 5 5 6'
]);