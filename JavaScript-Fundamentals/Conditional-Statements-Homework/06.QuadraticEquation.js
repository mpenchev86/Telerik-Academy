// Problem 6. Quadratic equation

// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
// Calculates and prints its real roots.
// Note: Quadratic equations may have 0, 1 or 2 real roots.

// 	Examples:

// a	 b	 c	  roots
// 2	 5	 -3	  x1=-3; x2=0.5
// -1	 3	 0	  x1=3; x2=0
// -0.5	 4	 -8	  x1=x2=4
// 5	 2	 8	  no real roots

// READ: Prompt, alert, etc. don't work in node build! Test it in the browser console. Thanks:)
var inputA = prompt("Enter coefficient a:", 0),
	inputB = prompt("Enter coefficient b:", 0),
	inputC = prompt("Enter coefficient c:", 0);
var a = parseFloat(inputA),
	b = parseFloat(inputB),
	c = parseFloat(inputC);
if (b * b - 4 * a * c < 0) {
	console.log("no real roots");
} else if (b * b - 4 * a * c > 0) {
	var firstRoot = (-b - Math.sqrt(b * b - 4 * a * c)) / (2 * a);
	var secondRoot = (-b + Math.sqrt(b * b - 4 * a * c)) / (2 * a);
	console.log("x1="+firstRoot);
	console.log("x2="+secondRoot);
} else {
	var onlyRoot = - b / (2 * a);
	console.log("x1=x2="+onlyRoot);
}