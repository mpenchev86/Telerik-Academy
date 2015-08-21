// Problem 6. Most frequent number

// Write a script that finds the most frequent number in an array.

// Example:

// 	input										result
// 	4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3		4 (5 times)


var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
	i,
	len,
	mostNum,
	tempMostNum,
	count = 0,
	tempCount;

len = arr.length;

while (len > 0) {
	
	tempMostNum = arr[0];
	tempCount = 0;

	for (i = 0, len = arr.length; i < len; i += 1) {
		if (arr[i] === tempMostNum) {
			tempCount += 1;
			arr.splice(i, 1);
			i -= 1;		// Because of 'arr.splice(i, 1)', the next iteration would skip 1 element
		}
	};

	if (tempCount > count) {
		count = tempCount;
		mostNum = tempMostNum;
	};
}

console.log(mostNum + " (" + count + " times)");