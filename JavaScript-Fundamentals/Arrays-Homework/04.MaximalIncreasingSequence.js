// Problem 4. Maximal increasing sequence

// Write a script that finds the maximal increasing sequence in an array.

// Example:

// 	input					result
// 	3, 2, 3, 4, 2, 2, 4		2, 3, 4


var arr = [3, 2, 3, 4, 2, 2, 4],
	tempStartIndex = 0,
	tempEndIndex = 0,
	maxStart = 0,
	maxEnd = 0,
	i,
	len,
	result = "";

for (i = 1, len = arr.length; i < len; i += 1) {
	if (arr[i] > arr[i - 1]) {
		tempEndIndex = i;
		if (tempEndIndex - tempStartIndex > maxEnd - maxStart) {
			maxStart = tempStartIndex;
			maxEnd = tempEndIndex;
		};
	} else {
		tempStartIndex = i;
	}
};

for (i = maxStart; i <= maxEnd; i += 1) {
	result += arr[i];
	if (i != maxEnd) {
		result += ", ";
	};
}

console.log(result);