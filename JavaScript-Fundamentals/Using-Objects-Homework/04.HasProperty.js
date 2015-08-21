// Problem 4. Has property

// Write a function that checks if a given object contains a given property.

// 	var obj  = …;
// 	var hasProp = hasProperty(obj, 'length');

var obj = { name: "The book of Everything", price: 29.99},
	prop = "page",
	hasProp;

function hasProperty (obj, prop) {
	if (obj.hasOwnProperty(prop)) {
		return true;
	} else {
		return false;
	}
}

hasProp = hasProperty(obj, prop);
console.log("The object has property '" + prop + "': " + hasProp);