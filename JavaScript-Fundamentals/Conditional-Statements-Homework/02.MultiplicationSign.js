// Problem 2. Multiplication Sign

// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.
// 	Examples:

// a	b		c		result
// 5	2		2		+
// -2	-2		1		+
// -2	4		3		-
// 0	-2.5	4		0
// -1	-0.5	-5.1	-

var a = 0,
	b = -2.5,
	c = 4;
if (a === 0 || b === 0 || c === 0) {
	console.log(0);
} else if (a > 0) {
	if (b > 0) {
		if (c > 0) {
			console.log("+");
		} else {
			console.log("-");
		}
	} else {
		if (c > 0) {
			console.log("-");
		} else {
			console.log("+");
		}
	}
} else {
	if (b > 0) {
		if (c > 0) {
			console.log("-");
		} else {
			console.log("+");
		}
	} else {
		if (c > 0) {
			console.log("+");
		} else {
			console.log("-");
		}
	}
}