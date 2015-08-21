// Problem 1. English digit

// Write a function that returns the last digit of given integer as an English word.
// Examples:

// input	output
// 512		two
// 1024		four
// 12309	nine


var intNumber = 12309;

function lastDigit(number) {
	var asWord = "",
		digit;

	digit = number % 10;
	switch (digit) {
		case 0: asWord = "zero"; break;
		case 1: asWord = "one"; break;
		case 2: asWord = "two"; break;
		case 3: asWord = "three"; break;
		case 4: asWord = "four"; break;
		case 5: asWord = "five"; break;
		case 6: asWord = "six"; break;
		case 7: asWord = "seven"; break;
		case 8: asWord = "eight"; break;
		case 9: asWord = "nine"; break;
	}

	return asWord;
}

console.log(lastDigit(intNumber));