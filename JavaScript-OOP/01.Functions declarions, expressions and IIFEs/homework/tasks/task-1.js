/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(arr) {
	var result = 0,
	len;

	if (typeof(arr) === 'undefined' || typeof(result) === 'undefined') {
		throw new Error();
	};

	len = arr.length;

	if (len === 0 || typeof(len) === 'undefined') {
		return null;
	};
	

	for (var i = 0; i < len; i += 1) {
		if (!parseInt(+arr[i])) {
			throw new Error();
		};
		result += +arr[i];
	};
	return result;
}

// console.log(sum(["14", [3]]));
module.exports = sum;