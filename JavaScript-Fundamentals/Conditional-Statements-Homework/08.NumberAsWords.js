// Problem 8. Number as words

// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
// 	Examples:

// numbers	number as words
// 	0			Zero
// 	9			Nine
// 	10			Ten
// 	12			Twelve
// 	19			Nineteen
// 	25			Twenty five
// 	98			Ninety eight
// 	98			Ninety eight
// 	273			Two hundred and seventy three
// 	400			Four hundred
// 	501			Five hundred and one
// 	617			Six hundred and seventeen
// 	711			Seven hundred and eleven
// 	999			Nine hundred and ninety nine

var inputNum = 501;

var oneToNine = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];   // An array for the digits - [1...9]
var tenToNineteen = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];   // Array for - [10...19]
var twentyToNinety = ["twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"];  // Array for the '10-s' - [20, 30...90]

var capitalizeFirstLetter = function (string) {		//Used once but let's just be clear what it does.
	return string.charAt(0).toUpperCase() + string.slice(1);
};

var finalText = "";

if ( parseInt(inputNum / 100) > 0) {	// If the number is >= 100, we print the digit for hundreds on the same line.
	var indexArr = parseInt(inputNum / 100) - 1;	//'parseInt()' is needed only when dividing, so a whole number is 
	var tempText = oneToNine[indexArr] + " hundred";
    if ( (inputNum % 100) != 0) {
        tempText += " and ";	// If the number isn't dividable by 100, we concatenate " and ", waiting for the rest of the number.
    };
    finalText += tempText;
};

if ( (inputNum % 100) > 19) {	// If The 10s part is > 19, we concatenate the corresponding value from 'twentyToNinety[]'
	var indexArr = parseInt((inputNum % 100) / 10) - 2;
	var tempText = twentyToNinety[indexArr];
    if ( ((inputNum % 100) % 10) > 0) {		// And if the digits part is > 0, we concatenate the corresponding value from 'oneToNine[]'
        var indexArr2 = ((inputNum % 100) % 10) - 1;
		var tempText2 = " " + oneToNine[indexArr2];
    	tempText += tempText2;
    };
    finalText += tempText;
} else {	// If The 10s part is <= 19 but > 9, we concatenate the corresponding value from 'tenToNineteen[]'
    if ( (inputNum % 100) > 9) {
		var indexArr = (inputNum % 100) - 10;
		var tempText = tenToNineteen[indexArr];
    	finalText += tempText;
    } else {	// If the 10s part is empty, we concatenate the corresponding value from 'oneToNine[]'
        if (inputNum % 100 > 0) {
        	var indexArr = (inputNum % 100) - 1;
			var tempText = oneToNine[indexArr];
    		finalText += tempText;
        };
    };
};

if (inputNum === 0) {	// Finally, if the number is 0 - "zero"
    finalText = "Zero";
};

finalText = capitalizeFirstLetter(finalText);
console.log(finalText);