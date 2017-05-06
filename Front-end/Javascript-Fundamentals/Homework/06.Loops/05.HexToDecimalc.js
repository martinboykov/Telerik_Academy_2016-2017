function solve(args) {
  var input = String(args);

  var hexKey = '0123456789ABCDEF';
  var sum = 0;

  var len = input.length;
  for (var i = 0; i < len; i += 1) {
    var digit = hexKey.indexOf(input[i]);

    sum = digit + sum * 16;
  }
  console.log(sum);
}
var numbers = [1, 2, 3, 4, 5];
console.log('[' + numbers.join(';') + ']');