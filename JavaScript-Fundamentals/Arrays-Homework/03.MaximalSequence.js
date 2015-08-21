// Problem 3. Maximal sequence

// Write a script that finds the maximal sequence of equal elements in an array.

// Example:

// 	input							result
// 	2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2

var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
	len,
	i,
	num,
	tempNum = arr[0],
	count = 0,
	tempCount = 0,
	result = "";

for (i = 0, len = arr.length; i < len; i += 1) {
	if (arr[i] === tempNum) {
		tempCount += 1;
		if (tempCount > count) {
			count = tempCount;
			num = tempNum;
		};
	} else {
		tempCount = 1;
		tempNum = arr[i];
	}
}

for (i = 0; i < count; i += 1) {
	result += num.toString();
	if (i != count - 1) {
		result += ", ";
	};
}

console.log(result);