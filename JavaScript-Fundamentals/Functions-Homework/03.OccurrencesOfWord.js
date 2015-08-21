// Problem 3. Occurrences of word

// Write a function that finds all the occurrences of word in a text.
// The search can be case sensitive or case insensitive.
// Use function overloading.


var theText = "Problem 3. Occurrences of word: Write a function that finds all the occurrences of word in a text. The search can be case sensitive or case insensitive. Use function overloading.",
	theWord = "tHE";

function findInText (inputText, wordToFind, isCaseSens) {
	var result,
		regExTemp,
		regEx,
		count;

	inputText = inputText || theText;
	wordToFind = wordToFind || theWord;
	isCaseSens = isCaseSens || false;

	regExTemp = '\\b' + wordToFind + '\\b';

	if (isCaseSens) {
		regEx = new RegExp(regExTemp, 'g');
	} else {
		regEx = new RegExp(regExTemp, 'gi');
	}

	count = inputText.match(regEx).length;
	result = "The word '" + wordToFind + "' is found " + count + " times in the text.";
	console.log(result);
}

findInText(theText, theWord);