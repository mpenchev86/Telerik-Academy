// Problem 5. Digit as word

// Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.
// 	Examples:

// digit	result
// 2		two
// 1		one
// 0		zero
// 5		five
// -0.1		not a digit
// hi		not a digit
// 9		nine
// 10		not a digit


// READ: Prompt, alert, etc. don't work in node build! Test it in the browser console. Thanks:)
var inputNum = prompt("Enter a digit", 3);
if (inputNum === null || inputNum.length != 1) {	// 'inputNum === null' checks if the user hit 'Cancel'
	console.log("Not a digit");
} else {
	var a = parseInt(inputNum);
	if (isNaN(a)) {
		console.log("Not a digit");
	} else {
		switch (a) {
			case 0: console.log("zero"); break;
			case 1: console.log("one"); break;
			case 2: console.log("two"); break;
			case 3: console.log("three"); break;
			case 4: console.log("four"); break;
			case 5: console.log("five"); break;
			case 6: console.log("six"); break;
			case 7: console.log("seven"); break;
			case 8: console.log("eight"); break;
			case 9: console.log("nine"); break;
		}
	}
}
