// Problem 7. Is prime

// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
// 	Examples:

// n	Prime?
// 1	false
// 2	true
// 3	true
// 4	false
// 9	false
// 37	true
// 97	true
// 51	false
// -3	false
// 0	false

var n = 71;
console.log(
	((n % 2) != 0 || (n === 2)) &&
	((n % 3) != 0 || (n === 3)) &&
	((n % 5) != 0 || (n === 5)) &&
	((n % 7) != 0 || (n === 7))? "Prime" : "Not prime");