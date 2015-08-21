// Problem 7. The biggest of five numbers

// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.
// 	Examples:

// a	b		c		d		e		biggest
// 5	2		2		4		1		5
// -2	-22		1		0		0		1
// -2	4		3		2		0		4
// 0	-2.5	0		5		5		5
// -3	-0.5	-1.1	-2		-0.1	-0.1

var a = -3,
	b = -0.5,
	c = -1.1,
	d = -2,
	e = -0.1;
if (a >= b) {
	if (a >= c) {
		if (a >= d) {
			if (a >= e) {
				console.log(a);
			} else {
				console.log(e);
			};
		} else {
			if (d >= e) {
				console.log(d);
			} else {
				console.log(e);
			};
		}
	} else {
		if (c >= d) {
			if (c >= e) {
				console.log(c);
			} else {
				console.log(e);
			};
		} else {
			if (d >= e) {
				console.log(d);
			} else {
				console.log(e);
			};
		}
	}
} else {
	if (b >= c) {
		if (b >= d) {
			if (b >= e) {
				console.log(b);
			} else {
				console.log(e);
			};
		} else {
			if (d >= e) {
				console.log(d);
			} else {
				console.log(e);
			};
		}
	} else {
		if (c >= d) {
			if (c >= e) {
				console.log(c);
			} else {
				console.log(e);
			};
		} else {
			if (d >= e) {
				console.log(d);
			} else {
				console.log(e);
			};
		}
	}
};