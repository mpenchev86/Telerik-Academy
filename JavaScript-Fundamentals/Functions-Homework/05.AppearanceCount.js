// Problem 5. Appearance count

// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.


var arr = [2, 3, 4, 5, 5, 6, 2, 3, 3, 8, 3, 0, 1, 1],
	inputNum = 3,
	count = 0,
	i,
	len;

function countInArr(arr, inputNum) {
	len = arr.length;
	for (i = 0; i < len; i += 1) {
		if (arr[i] === inputNum) {
			count += 1;
		};
	};
	return count;
};

function testFunc (countInArr) {
	if (countInArr == undefined || isNaN(countInArr)) {
		console.log("Error! //Very helpful message!");
	} else {
		console.log("The number appears " + countInArr + " times in the array.");		
	}
};

testFunc(countInArr(arr, inputNum));