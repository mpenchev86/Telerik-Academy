// Problem 6. Larger than neighbours

// Write a function that checks if the element at given position in given array of integers 
// is bigger than its two neighbours (when such exist).


var arr = [2, 5, 4, 5, 6, 2, 3, 0, 1],
	index = 8,
	len = arr.length,
	result;

function compareToNeighbours (arr, index) {
	var isBigger,
		nextElement = arr[index + 1],
		prevElement = arr[index - 1];

	if (index === 0) {
		if (arr[index] > nextElement) {
			isBigger = true;
		} else {
			isBigger = false;
		}
	} else if (index === (len - 1)) {
		if (arr[index] > prevElement) {
			isBigger = true;
		} else {
			isBigger = false;
		}
	} else {
		if (arr[index] > nextElement && arr[index] > prevElement) {
			isBigger = true;
		} else {
			isBigger = false;
		}
	}

	return isBigger;
}

result = compareToNeighbours(arr, index) ? "" : " not";
console.log("The number is" + result + " bigger than its neighbours.");

