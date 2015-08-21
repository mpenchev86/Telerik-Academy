// Problem 2. Remove elements

// Write a function that removes all elements with a given value.
// Attach it to the array type.
// Read about prototype and how to attach methods.

// 	var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
// 	arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];


var arr = [1,2,1,4,1,3,4,1,1,111,3,2,1,'1'];

Array.prototype.removeElem = function (elem) {
	var i, 
		len;

	for (i = 0, len = this.length; i < len; i += 1) {
		if (this[i] === elem) {
			this.splice(i, 1);
			i -= 1;
		};
	};
}

arr.removeElem(1);
console.log(arr);