// Problem 1. Numbers

// Write a script that prints all the numbers from 1 to N.

var n = prompt("Enter n:", 1);
	i;
if (n <= 1) {
	for (i = 1; i >= n; i -= 1) {
		console.log(i);
	};
} else {
	for (i = 1; i <= n; i += 1) {
		console.log(i);
	};
};