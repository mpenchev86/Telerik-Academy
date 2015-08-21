// Problem 4. Sort 3 numbers

// Sort 3 real values in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

// 	Examples:

// a	 b		c		result
// 5	 1		2		5 2 1
// -2	 -2		1		1 -2 -2
// -2	 4		3		4 3 -2
// 0	 -2.5	5		5 0 -2.5
// -1.1	 -0.5	-0.1	-0.1 -0.5 -1.1
// 10	 20		30		30 20 10
// 1	 1		1		1 1 1

var a = 0,
	b = -2.5,
	c = 5;
if (a >= b) {
	if (a >= c) {
		if (b >= c) {
			console.log(a+" "+b+" "+c);
		} else {
			console.log(a+" "+c+" "+b);
		}
	} else {
		console.log(c+" "+a+" "+b);
	}
} else {
	if (b >= c) {
		if (a >= c) {
			console.log(b+" "+a+" "+c);
		} else {
			console.log(b+" "+c+" "+a);			
		}
	} else {
		console.log(c+" "+b+" "+a);
	}
}
