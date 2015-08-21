// Problem 4. Third digit

// Write an expression that checks for given integer if its third digit (right-to-left) is 7.
// 	Examples:

// n		Third digit 7?
// 5			false
// 701			true
// 1732			true
// 9703			true
// 877			false
// 777877		false
// 9999799		true

var intNum = 262748;
var intThirdDigit = (intNum / 100) | 0;
console.log((intThirdDigit % 10) == 7 ? true : false);