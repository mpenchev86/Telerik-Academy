// Problem 2. Reverse number

// Write a function that reverses the digits of given decimal number.
// Example:

// input	output
// 256		652
// 123.45	54.321


var num = 123.45;

function reverseNum (num) {
	var numToString = num.toString(),
		reverseString = numToString.split("").reverse().join(""),
		stringToNum = Number(reverseString);
	console.log(stringToNum);
}

reverseNum(num);