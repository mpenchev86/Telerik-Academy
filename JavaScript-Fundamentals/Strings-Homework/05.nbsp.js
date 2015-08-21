// Problem 5. nbsp

// Write a function that replaces non breaking white-spaces in a text with &nbsp;


var inputText = "Write a function that replaces non breaking white-spaces in a text with &nbsp;";

function replaceSpaces (inputText) {
	var result,
		regex = new RegExp(' ', 'gi');

	result = inputText.replace(regex, '&nbsp;');

	return result
}

console.log(replaceSpaces(inputText));