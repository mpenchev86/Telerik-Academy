// Problem 3. Min/Max of sequence

// Write a script that finds the max and min number from a sequence of numbers.

var arr = [2, 3, -4, 11, -7, 13.2, 6, -8, -2, 0, 8],
	i, 
	min = arr[0], 
	max = arr[0];

for (i in arr) {
	if (arr[i] < min) {
		min = arr[i];
	};
	if (arr[i] > max) {
		max = arr[i];
	};
}

console.log("Min = " + min + "; Max = " + max);