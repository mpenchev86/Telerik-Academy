// Problem 1. Reverse string

// Write a JavaScript function that reverses a string and returns it.
// Example:

// input	output
// sample	elpmas


var str = '.elbadaernu s\'ti,wonk I - example for a reversed string';

function reverseString (str) {
	return str.split('').reverse().join('');
}

console.log(reverseString(str));