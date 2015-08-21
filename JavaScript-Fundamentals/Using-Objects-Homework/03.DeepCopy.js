// Problem 3. Deep copy

// Write a function that makes a deep copy of an object.
// The function should work for both primitive and reference types.

var obj1 = 5,
	obj2 = { breed: 'ulichna', tail: NaN},
	obj3 = null,
	obj4 = new Object(),
	copiedObj;

function deepCopy (obj) {
	var cloning = {};

	if (typeof obj !== "object" || obj === null) {
		cloning = obj;
		return cloning;
	}

	for (var prop in obj) {
		cloning[prop] = deepCopy(obj[prop]);
	};

	return cloning;
}

copiedObj = deepCopy(obj2);
console.log(copiedObj);