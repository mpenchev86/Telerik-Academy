// Problem 2. Numbers not divisible

// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var n = prompt("Enter n:", 1);
	i;
if (n <= 1) {
	for (i = 1; i >= n; i -= 1) {
		if ((i % 3) || (i % 7)) {
			console.log(i);			
		};
	};
} else {
	for (i = 1; i <= n; i += 1) {
		if ((i % 3) || (i % 7)) {
			console.log(i);			
		};
	};
};