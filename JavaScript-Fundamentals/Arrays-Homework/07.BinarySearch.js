// Problem 7. Binary search

// Write a script that finds the index of given element in a sorted array of integers 
// by using the binary search algorithm.


var arr = [-13.4, -8, -7, -4, -2.19, -1, 0, 2, 2, 3, 4, 6.43, 9, 12, 17],
	givenNum = 2,
	startIndex = 0,
	endIndex = arr.length - 1,
	middleIndex,
	result;

while (endIndex - startIndex >= 0) {
	middleIndex = ((startIndex + endIndex) / 2) | 0;
	if (givenNum < arr[middleIndex]) {
		endIndex = middleIndex - 1;
		continue;
	} else if (givenNum > arr[middleIndex]) {
		startIndex = middleIndex + 1;
		continue;
	} else {
		result = middleIndex;
		break;
	}
}

if (typeof(result) === "undefined") {
	console.log("No such number in this array. Kim Jong-un ate it.");
} else {
	console.log("First occurrence of the number is at index #" + result);
}