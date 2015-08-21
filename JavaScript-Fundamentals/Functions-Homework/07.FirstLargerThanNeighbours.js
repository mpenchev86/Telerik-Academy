// Problem 7. First larger than neighbours

// Write a function that returns the index of the first element in array that is larger than 
// its neighbours or -1, if there’s no such element.
// Use the function from the previous exercise.


var arr = [2, 3, 4, 5, 6, 2, 3, 0],
	i,
	len = arr.length,
	result;

function compareToNeighbours (arr) {
	var isBigger = -1;

	for (i = 0; i < len; i += 1) {
		if (i === 0) {
			if (arr[i] > arr[i + 1]) {
				isBigger = i; break;
			}
		} else if (i === (len - 1)) {
			if (arr[i] > arr[i - 1]) {
				isBigger = i; break;
			}
		} else {
			if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1]) {
				isBigger = i; break;
			}
		}
	};

	return isBigger;
}

result = compareToNeighbours(arr);

if (result === -1) {
	console.log("No such element");
} else {
	console.log("Index of first element larger than its neighbours: " + result);
}