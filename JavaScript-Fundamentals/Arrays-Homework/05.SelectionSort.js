// Problem 5. Selection sort

// Sorting an array means to arrange its elements in increasing order.
// Write a script to sort an array.
// Use the selection sort algorithm: Find the smallest element, move it at the first 
// position, find the smallest from the rest, move it at the second position, etc.

// Hint: Use a second array


var arr = [2, 3, -7, -1, 2, -1, 6, 4, -8, 9, -4, 12, 6.43, -2.19, 0, 5.99, 17, -13.4],
	sortedArr = [],
	result = "",
	indexMin = 0,
	i,
	len = arr.length;

while (len > 0) {

	for (i = 0; i < len; i += 1) {
		if (arr[i] <= arr[indexMin]) {
			indexMin = i;
		};
	}

	sortedArr.push(arr[indexMin]);		
	arr.splice(indexMin, 1);
	len -= 1;
	indexMin = 0;
}

for (i = 0, len = sortedArr.length; i < len; i += 1) {
	result += sortedArr[i];
	if (i != len - 1) {
		result += ", ";
	};
}

console.log(result);