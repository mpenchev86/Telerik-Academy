// Problem 3. The biggest of Three

// Write a script that finds the biggest of three numbers.
// Use nested if statements.
// 	Examples:

// a	 b		c		biggest
// 5	 2		2		5
// -2	 -2		1		1
// -2	 4		3		4
// 0	 -2.5	5		5
// -0.1	 -0.5	-1.1	-0.1

var a = -2,
	b = 4,
	c = 3;
if (a >= b) {
	if (a >= c) {
		console.log(a);
	} else {
		console.log(c);
	}
} else {
	if (b >= c) {
		console.log(b);
	} else {
		console.log(c);
	}
}
